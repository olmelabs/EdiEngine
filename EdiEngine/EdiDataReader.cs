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
                        currentInterchange.ISA = new ISA(elements);
                        break;

                    case "IEA":
                        currentInterchange.IEA = new IEA(elements);
                        batch.Interchanges.Add(currentInterchange);

                        int declaredGroupCount;
                        int.TryParse(elements[1], out declaredGroupCount);

                        if (declaredGroupCount != groupsCount)
                        {
                            AddValidationError(currentInterchange, $"Expected {declaredGroupCount} groups. Found {groupsCount}. Interchange # {elements[2]}.");
                        }

                        if (!CheckControlNumbersAreEgual(currentInterchange?.ISA.Content[13].Val, elements[2]))
                        {
                            int icn;
                            bool res;
                            res = int.TryParse(currentInterchange?.ISA.Content[13].Val, out icn); //remove "0" fill character

                            AddValidationError(currentInterchange, $"Control numbers do not match. ISA {(res ? icn.ToString() : currentInterchange?.ISA.Content[13].Val)}. IEA {elements[2]}.");
                        }

                        currentInterchange = null;
                        break;

                    case "GS":
                        groupsCount++;
                        transCount = 0;
                        currentGroup = new EdiGroup(elements[1]);
                        currentGroup.GS = new GS(elements);
                        break;

                    case "GE":
                        currentGroup.GE = new GE(elements);
                        currentInterchange.Groups.Add(currentGroup);

                        int declaredTransCount;
                        int.TryParse(elements[1], out declaredTransCount);

                        if (declaredTransCount != transCount)
                        {
                            AddValidationError(currentGroup, $"Expected {declaredTransCount} transactions. Found {transCount}. Group # {elements[2]}.");
                        }

                        if (!CheckControlNumbersAreEgual(currentGroup?.GS.Content[6].Val, elements[2]))
                        {
                            AddValidationError(currentGroup, $"Control numbers do not match. GS {currentGroup?.GS.Content[6].Val}. GE {elements[2]}.");
                        }

                        currentGroup = null;
                        break;

                    case "ST":
                        transCount++;
                        currentTrans = new EdiTrans();
                        currentTrans.ST = new ST(elements);
                        tranSegCount = 1;

                        string asmName = $"EdiEngine.Standards.X12_{currentGroup.GS.Content[8].Val}";
                        string typeName = $"{asmName}.M_{elements[1]}";

                        var map = Activator.CreateInstance(asmName, typeName).Unwrap();
                        if (!(map is MapLoop))
                        {
                            AddValidationError(currentTrans, $"Can not find map {elements[1]} for standard {currentGroup.GS.Content[8].Val}. Skipping Transaction.");
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

                        if (!CheckControlNumbersAreEgual(currentTrans.ST.Content[2].Val, elements[2]))
                        {
                            AddValidationError(currentTrans, $"Control numbers do not match. ST {currentTrans.ST.Content[2].Val}. SE {elements[2]}.");
                        }

                        currentTrans.SE = new SE(elements);
                        currentGroup.Transactions.Add(currentTrans);
                        currentTrans = null;
                        break;

                    default:
                        tranSegCount++;
                        mapReader?.ProcessRawSegment(elements[0], elements, tranSegCount);
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
