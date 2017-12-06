using System.IO;
using System.Reflection;
using System.Xml;
using EdiEngine.Common.Definitions;
using EdiEngine.Runtime;


namespace EdiEngine
{
    public class XmlMapReader : InetermediateFormatReader
    {
        public XmlMapReader(MapLoop map) : base(map)
        {
        }

        protected override EdiIntermediateEntity ReadIntermediateTree(string rawData)
        {
            XmlTextReader reader = new XmlTextReader(new StringReader(rawData));

            EdiIntermediateEntity context = new EdiIntermediateEntity(null);
            PropertyInfo prop = null;

            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        switch (reader.Name)
                        {
                            case "EdiTrans":
                                context = CreateEntity(context, "M");
                                break;

                            case "EdiLoop":
                                context = CreateEntity(context, "L");
                                break;

                            case "EdiSegment":
                                context = CreateEntity(context, "S");
                                break;

                            case "C":
                                context = CreateEntity(context, "C");
                                break;

                            case "E":
                                context = CreateEntity(context, null);

                                prop = typeof(EdiIntermediateEntity).GetProperty("E");

                                if (reader.IsEmptyElement)
                                    context = context?.Parent;
                                break;

                            case "Name":
                                prop = typeof(EdiIntermediateEntity).GetProperty(reader.LocalName);
                                break;
                        }

                        break;

                    case XmlNodeType.Text:
                        prop?.SetValue(context, reader.Value);
                        break;

                    case XmlNodeType.EndElement:
                        switch (reader.Name)
                        {
                            case "EdiTrans":
                            case "EdiLoop":
                            case "EdiSegment":
                            case "C":
                            case "E":
                                context = context?.Parent;
                                break;
                            case "Name":
                                prop = null;
                                break;
                        }
                        break;
                }
            }

            return context?.Children[0];
        }

        private EdiIntermediateEntity CreateEntity(EdiIntermediateEntity parent, string type)
        {
            EdiIntermediateEntity ent = new EdiIntermediateEntity(parent) { Type = type };
            parent?.Children.Add(ent);
            return ent;
        }
    }
}
