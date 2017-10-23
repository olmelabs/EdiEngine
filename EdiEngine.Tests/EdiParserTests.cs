using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using EdiEngine.Runtime;
using EdiEngine.Standards.X12_004010.Loops.M_940;
using EdiEngine.Standards.X12_004010.Segments;
using Newtonsoft.Json;

namespace EdiEngine.Tests
{
    [TestClass]
    public class EdiParserTests
    {
        [TestMethod]
        public void EdiParser_ParseGenericEdi940()
        {
            using (Stream s = GetType().Assembly.GetManifestResourceStream("EdiEngine.Tests.TestData.940.edi"))
            {
                EdiDataReader r = new EdiDataReader();
                EdiBatch b = new EdiBatch();
                r.FromStream(s, ref b);

                Assert.AreEqual(1, b.Interchanges.Count);
                Assert.AreEqual(1, b.Interchanges[0].Groups.Count);
                Assert.AreEqual(1, b.Interchanges[0].Groups[0].Transactions.Count);

                EdiTrans t = b.Interchanges[0].Groups[0].Transactions[0];

                int w05Count = t.Content.Count(l => l.Definition.GetType() == typeof(W05));
                int n1Count = t.Content.Count(l => l.Definition.GetType() == typeof(L_N1));
                int n1_1_Count = ((EdiLoop)t.Content.Where(l => l.Definition.GetType() == typeof(L_N1)).First()).Content.Count;
                int n1_2_Count = ((EdiLoop)t.Content.Where(l => l.Definition.GetType() == typeof(L_N1)).Skip(1).First()).Content.Count;
                int n1_3_Count = ((EdiLoop)t.Content.Where(l => l.Definition.GetType() == typeof(L_N1)).Skip(2).First()).Content.Count;
                int n9Count = t.Content.Count(l => l.Definition.GetType() == typeof(N9));
                int g62Count = t.Content.Count(l => l.Definition.GetType() == typeof(G62));
                int nteCount = t.Content.Count(l => l.Definition.GetType() == typeof(NTE));
                int w66Count = t.Content.Count(l => l.Definition.GetType() == typeof(W66));
                int lxCount = t.Content.Count(l => l.Definition.GetType() == typeof(L_LX));
                int lx_1_Count = ((EdiLoop)t.Content.Where(l => l.Definition.GetType() == typeof(L_LX)).First()).Content.Count;
                int lx_1_w01_Count = ((EdiLoop)((EdiLoop)t.Content.Where(l => l.Definition.GetType() == typeof(L_LX)).First())
                    .Content.Skip(1).First()).Content.Count;
                int w76Count = t.Content.Count(l => l.Definition.GetType() == typeof (W76));


                Assert.AreEqual(0, t.ValidationErrors.Count());

                Assert.AreEqual(1, w05Count);
                Assert.AreEqual(3, n1Count);
                Assert.AreEqual(3, n1_1_Count);
                Assert.AreEqual(3, n1_2_Count);
                Assert.AreEqual(2, n1_3_Count);
                Assert.AreEqual(1, n9Count);
                Assert.AreEqual(2, g62Count);
                Assert.AreEqual(1, nteCount);
                Assert.AreEqual(1, w66Count);
                Assert.AreEqual(3, lxCount);
                Assert.AreEqual(2, lx_1_Count);
                Assert.AreEqual(3, lx_1_w01_Count);
                Assert.AreEqual(1, w76Count);
            }
        }

        [TestMethod]
        public void EdiParser_ParseNestedLoopsEdi940()
        {
            using (Stream s = GetType().Assembly.GetManifestResourceStream("EdiEngine.Tests.TestData.940_2.edi"))
            {
                EdiDataReader r = new EdiDataReader();
                EdiBatch b = new EdiBatch();
                r.FromStream(s, ref b);

                EdiTrans t = b.Interchanges[0].Groups[0].Transactions[0];

                int w05Count = t.Content.Count(l => l.Definition.GetType() == typeof(W05));
                int w66Count = t.Content.Count(l => l.Definition.GetType() == typeof(W05));
                int llxCount = t.Content.Count(l => l.Definition.GetType() == typeof(L_LX));
                int slxCount = ((EdiLoop)t.Content.Where(l => l.Definition.GetType() == typeof(L_LX)).First())
                    .Content.Count(c => c.Definition.GetType() == typeof(LX));
                int lw01Count = ((EdiLoop)t.Content.Where(l => l.Definition.GetType() == typeof(L_LX)).First())
                    .Content.Count(l => l.Definition.GetType() == typeof(L_W01));
                int lw01n9Count = ((EdiLoop)((EdiLoop)t.Content.Where(l => l.Definition.GetType() == typeof(L_LX)).First())
                    .Content.First(l => l.Definition.GetType() == typeof(L_W01)))
                        .Content.Count(l => l.Definition.GetType() == typeof(N9));

                Assert.AreEqual(0, t.ValidationErrors.Count());

                Assert.AreEqual(1, w05Count);
                Assert.AreEqual(1, w66Count);
                Assert.AreEqual(1, llxCount);
                Assert.AreEqual(1, slxCount);
                Assert.AreEqual(1, lw01Count);
                Assert.AreEqual(3, lw01n9Count);
            }
        }

        [TestMethod]
        public void EdiParser_ParseFailedSegCount()
        {
            using (Stream s = GetType().Assembly.GetManifestResourceStream("EdiEngine.Tests.TestData.940_Failed_SE01.edi"))
            {
                EdiDataReader r = new EdiDataReader();
                EdiBatch b = new EdiBatch();
                r.FromStream(s, ref b);

                EdiTrans t = b.Interchanges[0].Groups[0].Transactions[0];

                Assert.AreEqual("Expected 12 segments. Found 9. Trans # 20066.", t.ValidationErrors.Last().Message);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(EdiParsingException))]
        public void EdiParser_ParseNonEDI()
        {
            using (Stream s = GetType().Assembly.GetManifestResourceStream("EdiEngine.Tests.TestData.NonEdi.edi"))
            {
                EdiDataReader r = new EdiDataReader();
                EdiBatch b = new EdiBatch();
                r.FromStream(s, ref b);
            }
        }

        [TestMethod]
        public void EdiParser_ParseMultipleInterchangesAndGroups()
        {
            using (Stream s = GetType().Assembly.GetManifestResourceStream("EdiEngine.Tests.TestData.MultipleInterchangesAndGroups.edi"))
            {
                EdiDataReader r = new EdiDataReader();
                EdiBatch b = new EdiBatch();
                r.FromStream(s, ref b);

                Assert.AreEqual(2, b.Interchanges.Count);
                Assert.AreEqual(2, b.Interchanges[0].Groups.Count);

                Assert.AreEqual(2, b.Interchanges[0].Groups[0].Transactions.Count);
                Assert.AreEqual(1, b.Interchanges[0].Groups[1].Transactions.Count);

                Assert.AreEqual(2, b.Interchanges[1].Groups[0].Transactions.Count);
                Assert.AreEqual(1, b.Interchanges[1].Groups[1].Transactions.Count);
            }
        }

        [TestMethod]
        public void EdiParser_WrongGroupsAndTranCount()
        {
            using (Stream s = GetType().Assembly.GetManifestResourceStream("EdiEngine.Tests.TestData.WrongGroupsAndTranCount.edi"))
            {
                EdiDataReader r = new EdiDataReader();
                EdiBatch b = new EdiBatch();
                r.FromStream(s, ref b);

                Assert.AreEqual("Expected 2 groups. Found 1. Interchange # 3438.", b.Interchanges[0].ValidationErrors.Last().Message);
                Assert.AreEqual("Expected 2 transactions. Found 1. Group # 3314.", b.Interchanges[0].Groups[0].ValidationErrors.Last().Message);
            }
        }

        [TestMethod]
        public void EdiParser_ControlNumbersMismatcht()
        {
            using (Stream s = GetType().Assembly.GetManifestResourceStream("EdiEngine.Tests.TestData.ControlNumbersMismatch.edi"))
            {
                EdiDataReader r = new EdiDataReader();
                EdiBatch b = new EdiBatch();
                r.FromStream(s, ref b);

                Assert.AreEqual("Control numbers do not match. ISA 3438. IEA 3439.", b.Interchanges[0].ValidationErrors.Last().Message);
                Assert.AreEqual("Control numbers do not match. GS 3314. GE 3315.", b.Interchanges[0].Groups[0].ValidationErrors.Last().Message);
                Assert.AreEqual("Control numbers do not match. ST 0001. SE 0002.", b.Interchanges[0].Groups[0].Transactions[0].ValidationErrors.Last().Message);
            }
        }

        [TestMethod]
        public void EdiParser_JsonSerializationTest()
        {
            using (Stream s = GetType().Assembly.GetManifestResourceStream("EdiEngine.Tests.TestData.940.edi"))
            {
                EdiDataReader r = new EdiDataReader();
                EdiBatch b = new EdiBatch();
                r.FromStream(s, ref b);

                JsonSerializerSettings settings = new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.All
                };

                //check no exception
                JsonConvert.SerializeObject(b, settings);

                //TODO: trans content deserialized as MappedObjectBase, not as actual type.
                //EdiBatch newBatch = JsonConvert.DeserializeObject<EdiBatch>(json);
            }
        }
    }
}
