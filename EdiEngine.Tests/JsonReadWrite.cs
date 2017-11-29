using EdiEngine.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.IO;
using EdiEngine.Standards.X12_004010.Maps;
using M_940 = EdiEngine.Standards.X12_004010.Maps.M_940;

namespace EdiEngine.Tests
{
    [TestClass]
    public class JsonReadWrite
    {
        [TestMethod]
        public void JsonReadWrite_JsonSerializationTest()
        {
            using (Stream s = GetType().Assembly.GetManifestResourceStream("EdiEngine.Tests.TestData.940.OK.edi"))
            {
                EdiDataReader r = new EdiDataReader();
                EdiBatch b = r.FromStream(s);

                //Write Json using newtonsoft
                //check no exception
                JsonConvert.SerializeObject(b);
                JsonConvert.SerializeObject(b.Interchanges[0].Groups[0].Transactions[0]);

                //or use writer to write to string or stream
                JsonDataWriter w  = new JsonDataWriter();
                string str = w.WriteToString(b);
                Stream stream = w.WriteToStream(b);

                Assert.IsNotNull(str);

                Assert.IsNotNull(stream);
                Assert.AreEqual(0, stream.Position);
                Assert.IsTrue(stream.CanRead);

                Assert.AreEqual(str.Length, stream.Length);
            }
        }

        [TestMethod]
        public void JsonReadWrite_DeserializeJsonOK()
        {
            string json = TestUtils.ReadResourceStream("EdiEngine.Tests.TestData.940.OK.json");

            M_940 map = new M_940();
            JsonMapReader r = new JsonMapReader(map);

            EdiTrans t = r.ReadToEnd(json);

            Assert.AreEqual(0, t.ValidationErrors.Count);
        }


        [TestMethod]
        public void JsonReadWrite_DeserializeJsonWithValidationErrors()
        {
            string json = TestUtils.ReadResourceStream("EdiEngine.Tests.TestData.940.ERR.json");

            M_940 map = new M_940();
            JsonMapReader r = new JsonMapReader(map);

            EdiTrans t = r.ReadToEnd(json);

            Assert.AreEqual(2, t.ValidationErrors.Count);
        }

        [TestMethod]
        public void JsonReadWrite_JsonSerializationHlLoopTest()
        {
            using (Stream s = GetType().Assembly.GetManifestResourceStream("EdiEngine.Tests.TestData.856.Crossdock.OK.edi"))
            {
                EdiDataReader r = new EdiDataReader();
                EdiBatch b = r.FromStream(s);

                JsonDataWriter jsonWriter = new JsonDataWriter();
                jsonWriter.WriteToString(b);
            }
        }

        [TestMethod]
        public void JsonReadWrite_DeserializeJsonHlLoopOk()
        {
            string json = TestUtils.ReadResourceStream("EdiEngine.Tests.TestData.856.Crossdock.OK.json");

            M_856 map = new M_856();
            JsonMapReader r = new JsonMapReader(map);

            EdiTrans t = r.ReadToEnd(json);

            Assert.AreEqual(0, t.ValidationErrors.Count);

            //string edi = TestUtils.WriteEdiEnvelope(t, "SH");
        }
    }
}
