using System.Linq;
using System.IO;
using EdiEngine.Common.Definitions;
using EdiEngine.Runtime;
using EdiEngine.Tests.Maps;
using SegmentDefinitions = EdiEngine.Standards.X12_004010.Segments;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using M_940 = EdiEngine.Standards.X12_004010.Maps.M_940;

namespace EdiEngine.Tests
{
    [TestClass]
    public class EdiWriterTests
    {
        [TestMethod]
        public void EdiWriter_CreateEdi940()
        {
            M_940 map = new M_940();
            EdiTrans t = new EdiTrans(map);

            // W05
            var sDef = (MapSegment)map.Content.First(s => s.Name == "W05");

            var seg = new EdiSegment(sDef);
            seg.Content.AddRange(new[]
            {
                new EdiSimpleDataElement(sDef.Content[0], "N"),
                new EdiSimpleDataElement(sDef.Content[1], "538686"),
                new EdiSimpleDataElement(sDef.Content[2], null),
                new EdiSimpleDataElement(sDef.Content[3], "001001"),
                new EdiSimpleDataElement(sDef.Content[4], "538686")
            });
            t.Content.Add(seg);

            //LX*1
            var lDef = (MapLoop)map.Content.First(s => s.Name == "L_LX");
            sDef = (MapSegment)lDef.Content.First(s => s.Name == "LX");

            EdiLoop lx = new EdiLoop(lDef, null);
            t.Content.Add(lx);

            seg = new EdiSegment(sDef);
            seg.Content.Add(new EdiSimpleDataElement(sDef.Content[0], "1"));
            lx.Content.Add(seg);

            //LX > W01 loop
            lDef = (MapLoop)lDef.Content.First(s => s.Name == "L_W01");
            sDef = (MapSegment)lDef.Content.First(s => s.Name == "W01");

            EdiLoop w01 = new EdiLoop(lDef, null);
            lx.Content.Add(w01);

            seg = new EdiSegment(sDef);
            seg.Content.AddRange(new[]
            {
                new EdiSimpleDataElement(sDef.Content[0], "12"),
                new EdiSimpleDataElement(sDef.Content[1], "CA"),
                new EdiSimpleDataElement(sDef.Content[1], "000100033330")
            });
            w01.Content.Add(seg);

            //LX*2
            lDef = (MapLoop)map.Content.First(s => s.Name == "L_LX");
            sDef = (MapSegment)lDef.Content.First(s => s.Name == "LX");

            lx = new EdiLoop(lDef, null);
            t.Content.Add(lx);

            seg = new EdiSegment(sDef);
            seg.Content.Add(new EdiSimpleDataElement(sDef.Content[0], "2"));
            lx.Content.Add(seg);

            //LX > W01 loop
            lDef = (MapLoop)lDef.Content.First(s => s.Name == "L_W01");
            sDef = (MapSegment)lDef.Content.First(s => s.Name == "W01");

            w01 = new EdiLoop(lDef, null);
            lx.Content.Add(w01);

            seg = new EdiSegment(sDef);
            seg.Content.AddRange(new[]
            {
                new EdiSimpleDataElement(sDef.Content[0], "10"),
                new EdiSimpleDataElement(sDef.Content[1], "CA"),
                new EdiSimpleDataElement(sDef.Content[1], "000100033332")
            });
            w01.Content.Add(seg);

            //write test envelope
            string data = TestUtils.WriteEdiEnvelope(t, "OW");

            //read produced results and check for errors.
            EdiDataReader r = new EdiDataReader();
            EdiBatch batch = r.FromString(data);

            Assert.AreEqual(1, batch.Interchanges.Count);
            Assert.AreEqual(0, batch.Interchanges[0].ValidationErrors.Count);

            Assert.AreEqual(1, batch.Interchanges[0].Groups.Count);
            Assert.AreEqual(0, batch.Interchanges[0].Groups[0].ValidationErrors.Count);

            EdiTrans trans = batch.Interchanges[0].Groups[0].Transactions[0];
            Assert.AreEqual(0, trans.ValidationErrors.Count);
        }

        [TestMethod]
        public void EdiWriter_FromJson()
        {
            //get sample json
            string jsonTrans;
            using (Stream s = GetType().Assembly.GetManifestResourceStream("EdiEngine.Tests.TestData.940.OK.json"))
            {
                if (s == null)
                    throw new InvalidDataException("stream is null");

                using (StreamReader sr = new StreamReader(s))
                {
                    jsonTrans = sr.ReadToEnd();
                }
            }

            //Read json and convert it to trans
            M_940 map = new M_940();
            JsonMapReader r = new JsonMapReader(map);
            EdiTrans t = r.ReadToEnd(jsonTrans);

            //write EDI
            string data = TestUtils.WriteEdiEnvelope(t, "OW");

            //Read produced results and check for errors and correct parsing
            EdiDataReader reader = new EdiDataReader();
            EdiBatch batch = reader.FromString(data);

            Assert.AreEqual(1, batch.Interchanges.Count);
            Assert.AreEqual(0, batch.Interchanges[0].ValidationErrors.Count);

            Assert.AreEqual(1, batch.Interchanges[0].Groups.Count);
            Assert.AreEqual(0, batch.Interchanges[0].Groups[0].ValidationErrors.Count);

            EdiTrans trans = batch.Interchanges[0].Groups[0].Transactions[0];
            Assert.AreEqual(0, trans.ValidationErrors.Count);

            int w05Count = trans.Content.Count(l => l.Definition.GetType() == typeof(SegmentDefinitions.W05));
            int n1Count = trans.Content.Count(l => l.Definition.GetType() == typeof(M_940.L_N1));
            int n1FirstIterationCount =
                ((EdiLoop)trans.Content.First(l => l.Definition.GetType() == typeof(M_940.L_N1))).Content.Count;
            int n1SecondIterationCount =
                ((EdiLoop)trans.Content.Where(l => l.Definition.GetType() == typeof(M_940.L_N1)).Skip(1).First())
                    .Content.Count;
            int n1ThirdIterationCount =
                ((EdiLoop)trans.Content.Where(l => l.Definition.GetType() == typeof(M_940.L_N1)).Skip(2).First())
                    .Content.Count;
            int n9Count = trans.Content.Count(l => l.Definition.GetType() == typeof(SegmentDefinitions.N9));
            int g62Count = trans.Content.Count(l => l.Definition.GetType() == typeof(SegmentDefinitions.G62));
            int nteCount = trans.Content.Count(l => l.Definition.GetType() == typeof(SegmentDefinitions.NTE));
            int w66Count = trans.Content.Count(l => l.Definition.GetType() == typeof(SegmentDefinitions.W66));
            int lxCount = trans.Content.Count(l => l.Definition.GetType() == typeof(M_940.L_LX));
            int lxFirstIterationCount =
                ((EdiLoop)trans.Content.First(l => l.Definition.GetType() == typeof(M_940.L_LX))).Content.Count;
            int lxFirstIterationW01Count =
                ((EdiLoop)((EdiLoop)trans.Content.First(l => l.Definition.GetType() == typeof(M_940.L_LX)))
                    .Content.Skip(1).First()).Content.Count;
            int w76Count = trans.Content.Count(l => l.Definition.GetType() == typeof(SegmentDefinitions.W76));

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

        [TestMethod]
        public void EdiWriter_WriteComposite()
        {
            //nonexisting map with just SLN segment to test composites
            M_001 map = new M_001();
            EdiTrans t = new EdiTrans(map);

            var sDef = (MapSegment)map.Content.First(s => s.Name == "SLN");

            var seg = new EdiSegment(sDef);

            //create composite
            var c001 = new EdiCompositeDataElement(sDef.Content[4], null);
            c001.Content.AddRange(new[] {
                    new EdiSimpleDataElement(c001.Definition.Content[0], "PC"),
                    new EdiSimpleDataElement(c001.Definition.Content[1], "21.1"),
                    new EdiSimpleDataElement(c001.Definition.Content[2], "22.2"),
                    new EdiSimpleDataElement(c001.Definition.Content[3], "EA"),
                    new EdiSimpleDataElement(c001.Definition.Content[4], "23.3"),
                    new EdiSimpleDataElement(c001.Definition.Content[5], "24.4")
                });

            //create segment
            seg.Content.AddRange(new DataElementBase[]
            {
                new EdiSimpleDataElement(sDef.Content[0], "1.1"),
                new EdiSimpleDataElement(sDef.Content[1], null),
                new EdiSimpleDataElement(sDef.Content[2], "I"),
                new EdiSimpleDataElement(sDef.Content[3], "10000"),
                c001,
                new EdiSimpleDataElement(sDef.Content[5], "1.56"),
                new EdiSimpleDataElement(sDef.Content[6], "TP"),
                new EdiSimpleDataElement(sDef.Content[7], null),
                new EdiSimpleDataElement(sDef.Content[8], "VC"),
                new EdiSimpleDataElement(sDef.Content[9], "P-875OS")
            });
            t.Content.Add(seg);

            string data = TestUtils.WriteEdiEnvelope(t, "ZZ");

            EdiDataReader r = new EdiDataReader("EdiEngine.Tests");
            EdiBatch b = r.FromString(data);

            EdiTrans t2 = b.Interchanges[0].Groups[0].Transactions[0];

            //1 error - unknown map
            Assert.AreEqual(1, t2.ValidationErrors.Count);

            var sln = (EdiSegment)t.Content.First();
            Assert.IsTrue(sln.Content[4] is EdiCompositeDataElement);
            Assert.AreEqual(6, ((EdiCompositeDataElement)sln.Content[4]).Content.Count);
        }
    }
}

