using EdiEngine.Common.Definitions;
using EdiEngine.Runtime;
using System;
using System.IO;

namespace EdiEngine
{
    public class EdiDataReader
    {
        private string _elementSeparator;
        private string _segmentSeparator;

        public void FromStream(Stream fileContent, ref EdiBatch batch)
        {
            string stringContent;
            using (StreamReader sr = new StreamReader(fileContent))
            {
                stringContent = sr.ReadToEnd();
            }

            FromString(stringContent, ref batch);
        }

        public void FromString(string fileContent, ref EdiBatch batch)
        {
            if (string.IsNullOrWhiteSpace(fileContent))
                throw new EdiParsingException("Empty File");

            if (!fileContent.StartsWith("ISA"))
                throw new EdiParsingException("ISA NOT FOUND");

            _elementSeparator = fileContent[3].ToString();
            _segmentSeparator = fileContent.Substring(105, fileContent.IndexOf($"GS{_elementSeparator}", StringComparison.Ordinal) - 105);

            string[] segments = fileContent.Split(new [] { _segmentSeparator }, StringSplitOptions.RemoveEmptyEntries);

            EdiInterchange currentInterchange = null;
            EdiGroup currentGroup = null;
            EdiTrans currentTrans = null;
            EdiMapReader mapReader = null;
            int tranSegCount = 0;
            int groupsCount = 0;
            int transCount = 0;

            foreach (string seg in segments)
            {
                string[] elements = seg.Split(new [] { _elementSeparator }, StringSplitOptions.None);

                switch (elements[0])
                {
                    case "ISA":
                        groupsCount = 0;
                        currentInterchange = new EdiInterchange
                        {
                            SegmentSeparator = _segmentSeparator,
                            ElementSeparator = _elementSeparator
                        };
                        currentInterchange.ISA.AddRange(elements);
                        break;

                    case "IEA":
                        currentInterchange?.IEA.AddRange(elements);
                        batch.Interchanges.Add(currentInterchange);

                        int declaredGroupCount;
                        int.TryParse(elements[1], out declaredGroupCount);

                        if (declaredGroupCount != groupsCount)
                        {
                            AddValidationError(currentInterchange, $"Expected {declaredGroupCount} groups. Found {groupsCount}. Interchange # {elements[2]}.");
                        }

                        if (!CheckControlNumbersAreEgual(currentInterchange?.ISA[13], elements[2]))
                        {
                            int icn;
                            bool res;
                            res = int.TryParse(currentInterchange?.ISA[13], out icn); //remove "0" fill character

                            AddValidationError(currentInterchange, $"Control numbers do not match. ISA {(res ? icn.ToString() : currentInterchange?.ISA[13])}. IEA {elements[2]}.");
                        }

                        currentInterchange = null;
                        break;

                    case "GS":
                        groupsCount++;
                        transCount = 0;
                        currentGroup = new EdiGroup();
                        currentGroup.GS.AddRange(elements);
                        break;

                    case "GE":
                        currentGroup?.GE.AddRange(elements);
                        currentInterchange?.Groups.Add(currentGroup);

                        int declaredTransCount;
                        int.TryParse(elements[1], out declaredTransCount);

                        if (declaredTransCount != transCount)
                        {
                            AddValidationError(currentGroup, $"Expected {declaredTransCount} transactions. Found {transCount}. Group # {elements[2]}.");
                        }

                        if (!CheckControlNumbersAreEgual(currentGroup?.GS[6], elements[2]))
                        {
                            AddValidationError(currentGroup, $"Control numbers do not match. GS {currentGroup?.GS[6]}. GE {elements[2]}.");
                        }

                        currentGroup = null;
                        break;

                    case "ST":
                        transCount++;
                        currentTrans = new EdiTrans();
                        currentTrans.ST.AddRange(elements);
                        tranSegCount = 1;

                        string asmName = $"EdiEngine.Standards.X12_{currentGroup?.GS[8]}";
                        string typeName = $"{asmName}.M_{elements[1]}";

                        var map = Activator.CreateInstance(asmName, typeName).Unwrap();
                        if (!(map is MapLoop))
                        {
                            AddValidationError(currentTrans, $"Can not find map {elements[1]} for standard {currentGroup?.GS[8]}. Skipping Transaction.");
                            break;
                        }
                        mapReader = new EdiMapReader((MapLoop)map, currentTrans);
                        break;

                    case "SE":
                        tranSegCount++;

                        int declaredSegCount;
                        int.TryParse(elements[1], out declaredSegCount);

                        if (declaredSegCount != tranSegCount)
                        {
                            AddValidationError(currentTrans, $"Expected {declaredSegCount} segments. Found {tranSegCount}. Trans # {elements[2]}.");
                        }

                        if (!CheckControlNumbersAreEgual(currentTrans?.ST[2], elements[2]))
                        {
                            AddValidationError(currentTrans, $"Control numbers do not match. ST {currentTrans?.ST[2]}. SE {elements[2]}.");
                        }

                        currentTrans?.SE.AddRange(elements);
                        currentGroup?.Transactions.Add(currentTrans);
                        currentTrans = null;
                        break;

                    default:
                        tranSegCount++;
                        mapReader?.ProcessRowSegment(elements[0], elements, tranSegCount);
                        break;
                }
            }

        }

        private void AddValidationError(IValidatedEntity obj, string message)
        {
            ValidationError err = new ValidationError()
            {
                Message = message
            };

            obj?.ValidationErrors.Add(err);
        }

        private bool CheckControlNumbersAreEgual(string headerIcn, string footerIcn)
        {
            int icn1, icn2;
            bool res;

            res = int.TryParse(headerIcn, out icn1);
            res = int.TryParse(footerIcn, out icn2) & res;

            return res && icn1 == icn2;
        }
    }
}
