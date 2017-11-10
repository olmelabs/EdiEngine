using System;
using EdiEngine.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Xml;
using System.Xml.Schema;

namespace EdiEngine.Tests
{
    [TestClass]
    public class XmlReadWrite
    {
        [TestMethod]
        public void XmlReadWrite_XmlSerializationTest()
        {
            using (Stream s = GetType().Assembly.GetManifestResourceStream("EdiEngine.Tests.TestData.940.edi"))
            {
                EdiDataReader r = new EdiDataReader();
                EdiBatch b = r.FromStream(s);

                XmlDataWriter w = new XmlDataWriter();
                string data = w.WriteToString(b);


                //Load XmlSchema
                XmlReaderSettings settings = new XmlReaderSettings { ValidationType = ValidationType.Schema };
                settings.ValidationFlags |= XmlSchemaValidationFlags.ReportValidationWarnings;

                using (Stream xsd = GetType().Assembly.GetManifestResourceStream("EdiEngine.Tests.edixml.xsd"))
                {
                    if (xsd == null)
                        throw new Exception("Xml schema not found");

                    XmlReader schemeReader = XmlReader.Create(xsd, settings);
                    settings.Schemas.Add("", schemeReader);
                }

                XmlReader reader = XmlReader.Create(new StringReader(data), settings);

                //ensure there is a valid xml
                XmlDocument xdoc = new XmlDocument();
                xdoc.Load(reader);

                //check parsed seg count
                int? segCount = xdoc.SelectNodes("//EdiSegment")?.Count;
                Assert.AreEqual(33, segCount);

                //validate against schema
                xdoc.Validate(SchemaErrorCallBack);
            }
        }

        private void SchemaErrorCallBack(object sender, ValidationEventArgs args)
        {
            //fail test in case validation errors
            Assert.AreEqual(0, 1);
        }
    }
}
