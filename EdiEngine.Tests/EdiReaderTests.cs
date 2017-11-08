using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Xml;
using EdiEngine.Runtime;
using EdiEngine.Standards.X12_004010.Loops.M_940;
using EdiEngine.Standards.X12_004010.Segments;
using Newtonsoft.Json;

namespace EdiEngine.Tests
{
    [TestClass]
    public class EdiReaderTests
    {
        [TestMethod]
        public void EdiReader_ParseGenericEdi940()
        {
            using (Stream s = GetType().Assembly.GetManifestResourceStream("EdiEngine.Tests.TestData.940.edi"))
            {
                EdiDataReader r = new EdiDataReader();
                EdiBatch b = r.FromStream(s);

                Assert.AreEqual(1, b.Interchanges.Count);
                Assert.AreEqual(1, b.Interchanges[0].Groups.Count);
                Assert.AreEqual(1, b.Interchanges[0].Groups[0].Transactions.Count);

                EdiTrans t = b.Interchanges[0].Groups[0].Transactions[0];

                int w05Count = t.Content.Count(l => l.Definition.GetType() == typeof(W05));
                int n1Count = t.Content.Count(l => l.Definition.GetType() == typeof(L_N1));
                int n1FirstIterationCount = ((EdiLoop)t.Content.First(l => l.Definition.GetType() == typeof(L_N1))).Content.Count;
                int n1SecondIterationCount = ((EdiLoop)t.Content.Where(l => l.Definition.GetType() == typeof(L_N1)).Skip(1).First()).Content.Count;
                int n1ThirdIterationCount = ((EdiLoop)t.Content.Where(l => l.Definition.GetType() == typeof(L_N1)).Skip(2).First()).Content.Count;
                int n9Count = t.Content.Count(l => l.Definition.GetType() == typeof(N9));
                int g62Count = t.Content.Count(l => l.Definition.GetType() == typeof(G62));
                int nteCount = t.Content.Count(l => l.Definition.GetType() == typeof(NTE));
                int w66Count = t.Content.Count(l => l.Definition.GetType() == typeof(W66));
                int lxCount = t.Content.Count(l => l.Definition.GetType() == typeof(L_LX));
                int lxFirstIterationCount = ((EdiLoop)t.Content.First(l => l.Definition.GetType() == typeof(L_LX))).Content.Count;
                int lxFirstIterationW01Count = ((EdiLoop)((EdiLoop)t.Content.First(l => l.Definition.GetType() == typeof(L_LX)))
                    .Content.Skip(1).First()).Content.Count;
                int w76Count = t.Content.Count(l => l.Definition.GetType() == typeof(W76));


                Assert.AreEqual(0, t.ValidationErrors.Count);

                Assert.AreEqual(1, w05Count);
                Assert.AreEqual(3, n1Count);
                Assert.AreEqual(3, n1FirstIterationCount);
                Assert.AreEqual(3, n1SecondIterationCount);
                Assert.AreEqual(2, n1ThirdIterationCount);
                Assert.AreEqual(1, n9Count);
                Assert.AreEqual(2, g62Count);
                Assert.AreEqual(1, nteCount);
                Assert.AreEqual(1, w66Count);
                Assert.AreEqual(3, lxCount);
                Assert.AreEqual(2, lxFirstIterationCount);
                Assert.AreEqual(3, lxFirstIterationW01Count);
                Assert.AreEqual(1, w76Count);
            }
        }

        [TestMethod]
        public void EdiReader_ParseNestedLoopsEdi940()
        {
            using (Stream s = GetType().Assembly.GetManifestResourceStream("EdiEngine.Tests.TestData.940_2.edi"))
            {
                EdiDataReader r = new EdiDataReader();
                EdiBatch b = r.FromStream(s);

                EdiTrans t = b.Interchanges[0].Groups[0].Transactions[0];

                int w05Count = t.Content.Count(l => l.Definition.GetType() == typeof(W05));
                int w66Count = t.Content.Count(l => l.Definition.GetType() == typeof(W05));
                int llxCount = t.Content.Count(l => l.Definition.GetType() == typeof(L_LX));
                int slxCount = ((EdiLoop)t.Content.First(l => l.Definition.GetType() == typeof(L_LX)))
                    .Content.Count(c => c.Definition.GetType() == typeof(LX));
                int lw01Count = ((EdiLoop)t.Content.First(l => l.Definition.GetType() == typeof(L_LX)))
                    .Content.Count(l => l.Definition.GetType() == typeof(L_W01));
                int lw01N9Count = ((EdiLoop)((EdiLoop)t.Content.First(l => l.Definition.GetType() == typeof(L_LX)))
                    .Content.First(l => l.Definition.GetType() == typeof(L_W01)))
                        .Content.Count(l => l.Definition.GetType() == typeof(N9));

                Assert.AreEqual(0, t.ValidationErrors.Count);

                Assert.AreEqual(1, w05Count);
                Assert.AreEqual(1, w66Count);
                Assert.AreEqual(1, llxCount);
                Assert.AreEqual(1, slxCount);
                Assert.AreEqual(1, lw01Count);
                Assert.AreEqual(3, lw01N9Count);
            }
        }

        [TestMethod]
        public void EdiReader_ParseFailedSegCount()
        {
            using (Stream s = GetType().Assembly.GetManifestResourceStream("EdiEngine.Tests.TestData.940_Failed_SE01.edi"))
            {
                EdiDataReader r = new EdiDataReader();
                EdiBatch b = r.FromStream(s);

                EdiTrans t = b.Interchanges[0].Groups[0].Transactions[0];

                Assert.AreEqual("Expected 12 segments. Found 9. Trans # 20066.", t.ValidationErrors.Last().Message);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(EdiParsingException))]
        public void EdiReader_ParseNonEDI()
        {
            using (Stream s = GetType().Assembly.GetManifestResourceStream("EdiEngine.Tests.TestData.NonEdi.edi"))
            {
                EdiDataReader r = new EdiDataReader();
                r.FromStream(s);

            }
        }

        [TestMethod]
        public void EdiReader_ParseMultipleInterchangesAndGroups()
        {
            using (Stream s = GetType().Assembly.GetManifestResourceStream("EdiEngine.Tests.TestData.MultipleInterchangesAndGroups.edi"))
            {
                EdiDataReader r = new EdiDataReader();
                EdiBatch b = r.FromStream(s);
                
                Assert.AreEqual(2, b.Interchanges.Count);
                Assert.AreEqual(2, b.Interchanges[0].Groups.Count);

                Assert.AreEqual(2, b.Interchanges[0].Groups[0].Transactions.Count);
                Assert.AreEqual(1, b.Interchanges[0].Groups[1].Transactions.Count);

                Assert.AreEqual(2, b.Interchanges[1].Groups[0].Transactions.Count);
                Assert.AreEqual(1, b.Interchanges[1].Groups[1].Transactions.Count);
            }
        }

        [TestMethod]
        public void EdiReader_WrongGroupsAndTranCount()
        {
            using (Stream s = GetType().Assembly.GetManifestResourceStream("EdiEngine.Tests.TestData.WrongGroupsAndTranCount.edi"))
            {
                EdiDataReader r = new EdiDataReader();
                EdiBatch b = r.FromStream(s);

                Assert.AreEqual("Expected 2 groups. Found 1. Interchange # 3438.", b.Interchanges[0].ValidationErrors.Last().Message);
                Assert.AreEqual("Expected 2 transactions. Found 1. Group # 3314.", b.Interchanges[0].Groups[0].ValidationErrors.Last().Message);
            }
        }

        [TestMethod]
        public void EdiReader_ControlNumbersMismatcht()
        {
            using (Stream s = GetType().Assembly.GetManifestResourceStream("EdiEngine.Tests.TestData.ControlNumbersMismatch.edi"))
            {
                EdiDataReader r = new EdiDataReader();
                EdiBatch b = r.FromStream(s);

                Assert.AreEqual("Control numbers do not match. ISA 000003438. IEA 000003439.", b.Interchanges[0].ValidationErrors.Last().Message);
                Assert.AreEqual("Control numbers do not match. GS 3314. GE 3315.", b.Interchanges[0].Groups[0].ValidationErrors.Last().Message);
                Assert.AreEqual("Control numbers do not match. ST 0001. SE 0002.", b.Interchanges[0].Groups[0].Transactions[0].ValidationErrors.Last().Message);
            }
        }

        [TestMethod]
        public void EdiReader_JsonSerializationTest()
        {
            using (Stream s = GetType().Assembly.GetManifestResourceStream("EdiEngine.Tests.TestData.940.edi"))
            {
                EdiDataReader r = new EdiDataReader();
                EdiBatch b = r.FromStream(s);

                //check no exception
                JsonConvert.SerializeObject(b);
                JsonConvert.SerializeObject(b.Interchanges[0].Groups[0].Transactions[0]);
            }
        }

        [TestMethod]
        public void EdiReader_XmlSerializationTest()
        {
            //TODO: Xml Serialize Deserialize
            //XmlSerializer will not work here because EDI types are resolved via reflection.
            //Can't statically add known types.
            using (Stream s = GetType().Assembly.GetManifestResourceStream("EdiEngine.Tests.TestData.940.edi"))
            {
                EdiDataReader r = new EdiDataReader();
                EdiBatch b = r.FromStream(s);

                XmlDataWriter w = new XmlDataWriter();
                string data = w.WriteToString(b);

                //ensure there is a valid xml
                XmlDocument xdoc = new XmlDocument();
                xdoc.LoadXml(data);

                int? segCount = xdoc.SelectNodes("//EdiSegment")?.Count;

                Assert.AreEqual(33, segCount);
            }
        }
    }
}
