using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using EdiEngine.Runtime;
using EdiEngine.Standards.X12_004010.Maps;
using EdiEngine.Standards.X12_004010.Segments;
using M_940 = EdiEngine.Standards.X12_004010.Maps.M_940;

namespace EdiEngine.Tests
{
    [TestClass]
    public class EdiReaderTests
    {
        [TestMethod]
        public void EdiReader_ParseGenericEdi940()
        {
            using (Stream s = GetType().Assembly.GetManifestResourceStream("EdiEngine.Tests.TestData.940.OK.edi"))
            {
                EdiDataReader r = new EdiDataReader();
                EdiBatch b = r.FromStream(s);

                Assert.AreEqual(1, b.Interchanges.Count);
                Assert.AreEqual(1, b.Interchanges[0].Groups.Count);
                Assert.AreEqual(1, b.Interchanges[0].Groups[0].Transactions.Count);

                EdiTrans t = b.Interchanges[0].Groups[0].Transactions[0];

                int w05Count = t.Content.Count(l => l.Definition.GetType() == typeof (W05));
                int n1Count = t.Content.Count(l => l.Definition.GetType() == typeof (M_940.L_N1));
                int n1FirstIterationCount =
                    ((EdiLoop) t.Content.First(l => l.Definition.GetType() == typeof (M_940.L_N1))).Content.Count;
                int n1SecondIterationCount =
                    ((EdiLoop) t.Content.Where(l => l.Definition.GetType() == typeof (M_940.L_N1)).Skip(1).First())
                        .Content.Count;
                int n1ThirdIterationCount =
                    ((EdiLoop) t.Content.Where(l => l.Definition.GetType() == typeof (M_940.L_N1)).Skip(2).First())
                        .Content.Count;
                int n9Count = t.Content.Count(l => l.Definition.GetType() == typeof (N9));
                int g62Count = t.Content.Count(l => l.Definition.GetType() == typeof (G62));
                int nteCount = t.Content.Count(l => l.Definition.GetType() == typeof (NTE));
                int w66Count = t.Content.Count(l => l.Definition.GetType() == typeof (W66));
                int lxCount = t.Content.Count(l => l.Definition.GetType() == typeof (M_940.L_LX));
                int lxFirstIterationCount =
                    ((EdiLoop) t.Content.First(l => l.Definition.GetType() == typeof (M_940.L_LX))).Content.Count;
                int lxFirstIterationW01Count =
                    ((EdiLoop) ((EdiLoop) t.Content.First(l => l.Definition.GetType() == typeof (M_940.L_LX)))
                        .Content.Skip(1).First()).Content.Count;
                int w76Count = t.Content.Count(l => l.Definition.GetType() == typeof (W76));


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
        public void EdiReader_ParseGenericEdi850()
        {
            using (Stream s = GetType().Assembly.GetManifestResourceStream("EdiEngine.Tests.TestData.850.OK.edi"))
            {
                EdiDataReader r = new EdiDataReader();
                EdiBatch b = r.FromStream(s);

                Assert.AreEqual(1, b.Interchanges.Count);
                Assert.AreEqual(1, b.Interchanges[0].Groups.Count);
                Assert.AreEqual(1, b.Interchanges[0].Groups[0].Transactions.Count);

                Assert.AreEqual(1, b.Interchanges.Count);
                Assert.AreEqual(1, b.Interchanges[0].Groups.Count);
                Assert.AreEqual(1, b.Interchanges[0].Groups[0].Transactions.Count);

                EdiTrans t = b.Interchanges[0].Groups[0].Transactions[0];

                int rootSegCount = t.Content.Count(seg => seg is EdiSegment);
                int rootLoopCount = t.Content.Count(l => l is EdiLoop);
                int n1LoopCount = t.Content.Count(l => l.Definition.GetType() == typeof (M_850.L_N1));
                int n1ContentCount =
                    ((EdiLoop) t.Content.First(l => l.Definition.GetType() == typeof (M_850.L_N1))).Content.Count();

                int po1LoopCount = t.Content.Count(l => l.Definition.GetType() == typeof (M_850.L_PO1));
                int pidLoopCount = t.Content.Where(l => l.Definition.GetType() == typeof (M_850.L_PO1))
                    .Select(l2 => l2.Definition.GetType() == typeof (M_850.L_PID)).Count();

                int po1Count = 0;
                int pidCount = 0;
                int po4Count = 0;
                var lst = t.Content.Where(l => l.Definition.GetType() == typeof (M_850.L_PO1)).Select(l => l).ToList();
                lst.ForEach(l =>
                {
                    var po1Loop = (EdiLoop) l;
                    if (po1Loop.Content[0].Definition.GetType() == typeof (PO1))
                        po1Count++;

                    if (po1Loop.Content[2].Definition.GetType() == typeof (PO4))
                        po4Count++;

                    EdiLoop pidLoop =
                        (EdiLoop) po1Loop.Content.First(l2 => l2.Definition.GetType() == typeof (M_850.L_PID));
                    if (pidLoop.Content[0].Definition.GetType() == typeof (PID))
                        pidCount++;
                });

                int cttLoopCount = t.Content.Count(l => l.Definition.GetType() == typeof (M_850.L_CTT));
                int cttCount = ((EdiLoop) t.Content.First(l => l.Definition.GetType() == typeof (M_850.L_CTT)))
                    .Content.Count(s2 => s2.Definition.GetType() == typeof (CTT));


                Assert.AreEqual(0, t.ValidationErrors.Count);

                Assert.AreEqual(8, rootSegCount);
                Assert.AreEqual(8, rootLoopCount);
                Assert.AreEqual(1, n1LoopCount);
                Assert.AreEqual(3, n1ContentCount);
                Assert.AreEqual(6, po1LoopCount);
                Assert.AreEqual(6, po1Count);
                Assert.AreEqual(6, pidLoopCount);
                Assert.AreEqual(6, pidCount);
                Assert.AreEqual(6, po4Count);
                Assert.AreEqual(1, cttLoopCount);
                Assert.AreEqual(1, cttCount);
            }
        }

        [TestMethod]
        public void EdiReader_ParseNestedLoopsEdi940()
        {
            using (Stream s = GetType().Assembly.GetManifestResourceStream("EdiEngine.Tests.TestData.940.2.OK.edi"))
            {
                EdiDataReader r = new EdiDataReader();
                EdiBatch b = r.FromStream(s);

                EdiTrans t = b.Interchanges[0].Groups[0].Transactions[0];

                int w05Count = t.Content.Count(l => l.Definition.GetType() == typeof (W05));
                int w66Count = t.Content.Count(l => l.Definition.GetType() == typeof (W05));
                int llxCount = t.Content.Count(l => l.Definition.GetType() == typeof (M_940.L_LX));
                int slxCount = ((EdiLoop) t.Content.First(l => l.Definition.GetType() == typeof (M_940.L_LX)))
                    .Content.Count(c => c.Definition.GetType() == typeof (LX));
                int lw01Count = ((EdiLoop) t.Content.First(l => l.Definition.GetType() == typeof (M_940.L_LX)))
                    .Content.Count(l => l.Definition.GetType() == typeof (M_940.L_W01));
                int lw01N9Count = ((EdiLoop)
                    ((EdiLoop) t.Content.First(l => l.Definition.GetType() == typeof (M_940.L_LX)))
                        .Content.First(l => l.Definition.GetType() == typeof (M_940.L_W01)))
                    .Content.Count(l => l.Definition.GetType() == typeof (N9));

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
            using (
                Stream s = GetType().Assembly.GetManifestResourceStream("EdiEngine.Tests.TestData.940_Failed_SE01.edi"))
            {
                EdiDataReader r = new EdiDataReader();
                EdiBatch b = r.FromStream(s);

                EdiTrans t = b.Interchanges[0].Groups[0].Transactions[0];

                Assert.AreEqual("Expected 12 segments. Found 9. Trans # 20066.", t.ValidationErrors.Last().Message);
            }
        }

        [TestMethod]
        [ExpectedException(typeof (EdiParsingException))]
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
            using (
                Stream s =
                    GetType()
                        .Assembly.GetManifestResourceStream("EdiEngine.Tests.TestData.MultipleInterchangesAndGroups.edi")
                )
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
            using (
                Stream s =
                    GetType().Assembly.GetManifestResourceStream("EdiEngine.Tests.TestData.WrongGroupsAndTranCount.edi")
                )
            {
                EdiDataReader r = new EdiDataReader();
                EdiBatch b = r.FromStream(s);

                Assert.AreEqual("Expected 2 groups. Found 1. Interchange # 3438.",
                    b.Interchanges[0].ValidationErrors.Last().Message);
                Assert.AreEqual("Expected 2 transactions. Found 1. Group # 3314.",
                    b.Interchanges[0].Groups[0].ValidationErrors.Last().Message);
            }
        }

        [TestMethod]
        public void EdiReader_ControlNumbersMismatcht()
        {
            using (
                Stream s =
                    GetType().Assembly.GetManifestResourceStream("EdiEngine.Tests.TestData.ControlNumbersMismatch.edi"))
            {
                EdiDataReader r = new EdiDataReader();
                EdiBatch b = r.FromStream(s);

                Assert.AreEqual("Control numbers do not match. ISA 000003438. IEA 000003439.",
                    b.Interchanges[0].ValidationErrors.Last().Message);
                Assert.AreEqual("Control numbers do not match. GS 3314. GE 3315.",
                    b.Interchanges[0].Groups[0].ValidationErrors.Last().Message);
                Assert.AreEqual("Control numbers do not match. ST 0001. SE 0002.",
                    b.Interchanges[0].Groups[0].Transactions[0].ValidationErrors.Last().Message);
            }
        }

        [TestMethod]
        public void EdiReader_ParseGenericEdi940WithExternalMapAssembly()
        {
            using (Stream s = GetType().Assembly.GetManifestResourceStream("EdiEngine.Tests.TestData.940.W05.Only.edi"))
            {
                EdiDataReader r = new EdiDataReader("EdiEngine.Tests");
                EdiBatch b = r.FromStream(s);

                EdiTrans t = b.Interchanges[0].Groups[0].Transactions[0];

                Assert.AreEqual(0, t.ValidationErrors.Count);
            }
        }

        [TestMethod]
        public void EdiReader_ParseCrossDock856HL()
        {
            using (Stream s = GetType().Assembly.GetManifestResourceStream("EdiEngine.Tests.TestData.856.Crossdock.OK.edi"))
            {
                EdiDataReader r = new EdiDataReader();
                EdiBatch b = r.FromStream(s);

                Assert.AreEqual(1, b.Interchanges.Count);
                Assert.AreEqual(1, b.Interchanges[0].Groups.Count);
                Assert.AreEqual(1, b.Interchanges[0].Groups[0].Transactions.Count);

                EdiTrans t = b.Interchanges[0].Groups[0].Transactions[0];

                Assert.AreEqual(0, t.ValidationErrors.Count);
            }
        }

        [TestMethod]
        public void EdiReader_ParseCompositeOk()
        {
            using (Stream s = GetType().Assembly.GetManifestResourceStream("EdiEngine.Tests.TestData.850.Composite.SLN.OK.edi"))
            {
                EdiDataReader r = new EdiDataReader();
                EdiBatch b = r.FromStream(s);

                Assert.AreEqual(1, b.Interchanges.Count);
                Assert.AreEqual(1, b.Interchanges[0].Groups.Count);
                Assert.AreEqual(1, b.Interchanges[0].Groups[0].Transactions.Count);

                EdiTrans t = b.Interchanges[0].Groups[0].Transactions[0];

                Assert.AreEqual(0, t.ValidationErrors.Count);
            }
        }
    }
}
