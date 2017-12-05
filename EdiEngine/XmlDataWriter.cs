using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml;
using EdiEngine.Runtime;
using EdiEngine.Xml;

namespace EdiEngine
{
    public class XmlDataWriter : DataWriter
    {
        private readonly XmlWriterSettings _settings;

        public XmlDataWriter()
        {
            _settings = new XmlWriterSettings
            {
                OmitXmlDeclaration = true,
                Encoding = Encoding.UTF8,
                CloseOutput = false
            };
        }

        public XmlDataWriter(XmlWriterSettings settings)
        {
            _settings = settings;
        }

        public override string WriteToString(EdiBatch batch)
        {
            using (Stream s = WriteToStream(batch))
            {
                using (StreamReader r = new StreamReader(s, _settings.Encoding))
                {
                    return r.ReadToEnd();
                }
            }
        }

        public override Stream WriteToStream(EdiBatch batch)
        {
            Stream s = new MemoryStream();

            XmlWriter w = XmlWriter.Create(s, _settings);
            w.WriteStartDocument();

            WrtiteObject(batch, w);

            w.WriteEndDocument();
            w.Flush();
            w.Close();

            s.Position = 0;
            return s;
        }

        private void WrtiteObject(object obj, XmlWriter w)
        {
            //check element start - end tag should be omitted
            var elementAttr = obj.GetType().GetCustomAttributes().OfType<XmlElementAttribute>().FirstOrDefault();
            bool writeStratEndElement = !(elementAttr?.IgnoreElementRoot ?? false);
            var startElementName = elementAttr?.ElementName ?? obj.GetType().Name;

            if (writeStratEndElement)
                w.WriteStartElement(startElementName);

            //order properties according to Order
            var properties = obj.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .OrderBy(p => p.GetCustomAttributes().OfType<XmlPropertyAttribute>().FirstOrDefault()?.Order);

            foreach (PropertyInfo prop in properties)
            {
                //check property is ignored in attr
                var ignoreAttr = prop.GetCustomAttributes().OfType<XmlIgnoreAttribute>().FirstOrDefault();
                if (ignoreAttr != null)
                    continue;

                //check property name redefined in attr
                var propAttr = prop.GetCustomAttributes().OfType<XmlPropertyAttribute>().FirstOrDefault();
                var elementName = propAttr?.PropertyName ?? prop.Name;

                if (prop.PropertyType.IsGenericType && (prop.PropertyType.GetGenericTypeDefinition() == typeof(List<>)))
                {
                    var children = ((IEnumerable<object>)prop.GetValue(obj)).ToArray();
                    if (!children.Any())
                        continue;

                    w.WriteStartElement(elementName);
                    foreach (object child in children)
                    {
                        WrtiteObject(child, w);
                    }
                    w.WriteEndElement();
                }
                else if (typeof (EdiBaseEntity).IsAssignableFrom(prop.PropertyType))
                {
                    WrtiteObject(prop.GetValue(obj), w);
                }
                else
                {
                    var val = prop.GetValue(obj);
                    if (val != null)
                        w.WriteElementString(elementName, val.ToString());
                }
            }

            if (writeStratEndElement)
                w.WriteEndElement();
        }
    }
}
