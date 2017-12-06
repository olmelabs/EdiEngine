using System;
using EdiEngine.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using EdiEngine.Standards.X12_004010.Maps;
using EdiEngine.Tests.Maps;
using M_940 = EdiEngine.Standards.X12_004010.Maps.M_940;
using System.Linq;

namespace EdiEngine.Tests
{
    [TestClass]
    public class XmlReadWriteTests
    {
        [TestMethod]
        public void XmlReadWrite_XmlSerializationTest()
        {
            using (Stream s = GetType().Assembly.GetManifestResourceStream("EdiEngine.Tests.TestData.940.OK.edi"))
            {
                EdiDataReader r = new EdiDataReader();
                EdiBatch b = r.FromStream(s);

                XmlDataWriter w = new XmlDataWriter();
                string data = w.WriteToString(b);

                Stream stream = w.WriteToStream(b);

                Assert.IsNotNull(stream);
                Assert.AreEqual(0, stream.Position);
                Assert.IsTrue(stream.CanRead);
                
                XmlDocument xdoc = ValidateBySchema(data);

                //check parsed seg count
                int? segCount = xdoc.SelectNodes("//EdiSegment")?.Count;
                Assert.AreEqual(33, segCount);

            }
        }

        [TestMethod]
        public void XmlReadWrite_DeserializeXmlOK()
        {
            string xml = TestUtils.ReadResourceStream("EdiEngine.Tests.TestData.940.OK.xml");

            M_940 map = new M_940();
            XmlMapReader r = new XmlMapReader(map);

            EdiTrans t = r.ReadToEnd(xml);

            Assert.AreEqual(0, t.ValidationErrors.Count);

            //string edi = TestUtils.WriteEdiEnvelope(t, "SH");
        }

        [TestMethod]
        public void XmlReadWrite_DeserializeXmlWithValidationErrors()
        {
            string xml = TestUtils.ReadResourceStream("EdiEngine.Tests.TestData.940.ERR.xml");

            M_940 map = new M_940();
            XmlMapReader r = new XmlMapReader(map);

            EdiTrans t = r.ReadToEnd(xml);

            Assert.AreEqual(2, t.ValidationErrors.Count);
        }

        [TestMethod]
        public void XmlReadWrite_XmlSerializationHlLoopTest()
        {
            using (Stream s = GetType().Assembly.GetManifestResourceStream("EdiEngine.Tests.TestData.856.Crossdock.OK.edi"))
            {
                EdiDataReader r = new EdiDataReader();
                EdiBatch b = r.FromStream(s);

                XmlDataWriter w = new XmlDataWriter();
                string data = w.WriteToString(b);

                XmlDocument xdoc = ValidateBySchema(data);

                //check parsed seg count
                int? segCount = xdoc.SelectNodes("//EdiSegment")?.Count;
                Assert.AreEqual(61, segCount);
            }
        }

        [TestMethod]
        public void XmlReadWrite_DeserializeXmlHlLoopOk()
        {
            string xml = TestUtils.ReadResourceStream("EdiEngine.Tests.TestData.856.Crossdock.OK.xml");

            M_856 map = new M_856();
            XmlMapReader r = new XmlMapReader(map);

            EdiTrans t = r.ReadToEnd(xml);

            Assert.AreEqual(0, t.ValidationErrors.Count);

            //write complete envelope
            //string edi = TestUtils.WriteEdiEnvelope(t, "SH");
        }

        [TestMethod]
        public void XmlReadWrite_SerializeComposite()
        {
            using (Stream s = GetType().Assembly.GetManifestResourceStream("EdiEngine.Tests.TestData.850.Composite.SLN.OK.edi"))
            {
                EdiDataReader r = new EdiDataReader();
                EdiBatch b = r.FromStream(s);

                XmlDataWriter w = new XmlDataWriter();
                string data = w.WriteToString(b);

                XmlDocument xdoc = ValidateBySchema(data);

                //check parsed seg count
                int? segCount = xdoc.SelectNodes("//EdiSegment")?.Count;
                Assert.AreEqual(15, segCount);
            }
        }

        [TestMethod]
        public void XmlReadWrite_DeserializeComposite()
        {
            string xml = TestUtils.ReadResourceStream("EdiEngine.Tests.TestData.001.Fake.Composite.xml");

            M_001 map = new M_001();
            XmlMapReader r = new XmlMapReader(map);

            EdiTrans t = r.ReadToEnd(xml);

            Assert.AreEqual(0, t.ValidationErrors.Count);

            var sln = (EdiSegment)t.Content.First();
            Assert.IsTrue(sln.Content[4] is EdiCompositeDataElement);
            Assert.AreEqual(6, ((EdiCompositeDataElement)sln.Content[4]).Content.Count);

        }

        private XmlDocument ValidateBySchema(string data)
        {
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

            //validate against schema
            xdoc.Validate(SchemaErrorCallBack);

            return xdoc;
        }

        private void SchemaErrorCallBack(object sender, ValidationEventArgs args)
        {
            //fail test in case validation errors
            Assert.AreEqual(0, 1);
        }

    }
}
