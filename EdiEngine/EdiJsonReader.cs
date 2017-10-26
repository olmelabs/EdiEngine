using EdiEngine.Common.Definitions;
using EdiEngine.Runtime;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;

namespace EdiEngine
{
    public class EdiJsonReader
    {
        private readonly MapBaseEntity _map;

        public EdiJsonReader(MapBaseEntity map)
        {
            _map = map;
        }

        public EdiTrans ReadToEnd(string jsonTrans)
        {
            EdiTrans trans = new EdiTrans(_map);

            //for now - just convert json to raw EDI. This is not the best option, but fast and working one. 
            //may be just need to refactor in future and create fair map reader.
            string ediTrans = ReadJson(jsonTrans);

            string[] rawSegments = ediTrans.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            EdiMapReader mapReader = new EdiMapReader((MapLoop)_map, trans);

            int tranSegCount = 1;
            foreach (string seg in rawSegments)
            {
                string[] elements = seg.Split(new[] { "*" }, StringSplitOptions.None);
                mapReader.ProcessRawSegment(elements[0], elements, tranSegCount);
            }

            return trans;
        }

        private string ReadJson(string jsonTrans)
        {
            JsonTextReader reader = new JsonTextReader(new StringReader(jsonTrans));

            StringBuilder sb = new StringBuilder();

            ExectedTokens nextToken = ExectedTokens.None;

            while (reader.Read())
            {
                if (reader.TokenType == JsonToken.PropertyName)
                {
                    switch (reader.Value.ToString())
                    {
                        case "Name":
                            nextToken = ExectedTokens.Segment;
                            break;

                        case "E":
                            nextToken = ExectedTokens.DataElement;
                            break;

                        case "Content":
                            break;
                    }
                }
                else if (reader.TokenType == JsonToken.String)
                {
                    string val = reader.Value.ToString();
                    ProcessToken(nextToken, val, sb);
                }
            }

            return sb.ToString();
        }

        private void ProcessToken(ExectedTokens token, string val, StringBuilder sb)
        {
            switch (token)
            {
                case ExectedTokens.Segment:
                    if (val.StartsWith("M_"))
                        return;
                    if (val.StartsWith("L_"))
                        return;

                    if (sb.Length > 0)
                    {
                        sb.AppendLine();
                    }
                    sb.Append(val);
                    break;

                case ExectedTokens.DataElement:
                    sb.Append($"*{val}");
                    break;
            }

        }

        private enum ExectedTokens
        {
            Segment,
            DataElement,
            None
        }
    }
}
