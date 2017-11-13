using System;
using EdiEngine.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using EdiEngine.Standards.X12_004010;

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

        [TestMethod]
        public void XmlReadWrite_DeserializeXmlOK()
        {
            string xml = TestUtils.ReadResourceStream("EdiEngine.Tests.TestData.transactionXml.OK.xml");

            M_940 map = new M_940();
            XmlMapReader r = new XmlMapReader(map);

            EdiTrans t = r.ReadToEnd(xml);

            Assert.AreEqual(0, t.ValidationErrors.Count);
        }

        [TestMethod]
        public void XmlReadWrite_DeserializeXmlWithValidationErrors()
        {
            string xml = TestUtils.ReadResourceStream("EdiEngine.Tests.TestData.transactionXml.ERR.xml");

            M_940 map = new M_940();
            XmlMapReader r = new XmlMapReader(map);

            EdiTrans t = r.ReadToEnd(xml);

            Assert.AreEqual(2, t.ValidationErrors.Count);
        }
    }
}
