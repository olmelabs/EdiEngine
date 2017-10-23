using System.Linq;
using EdiEngine.Common.Definitions;
using EdiEngine.Runtime;
using EdiEngine.Standards.X12_004010;
using SegmentDefinitions = EdiEngine.Standards.X12_004010.Segments;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EdiEngine.Tests
{
    [TestClass]
    public class EdiWriterTests
    {

        [TestMethod]
        public void EdiWriter_CreateEdi940()
        {
            M_940 map = new M_940();
            EdiTrans t = new EdiTrans { Definition = map };

            // W05
            var sDef = (MapSegment)map.Content.First(s => s.Name == "W05");

            var seg = new EdiSegment(sDef);
            seg.Content.AddRange(new[] {
                new EdiDataElement(sDef.Content[0], "N"),
                new EdiDataElement(sDef.Content[1], "538686"),
                new EdiDataElement(sDef.Content[2], null),
                new EdiDataElement(sDef.Content[3], "001001"),
                new EdiDataElement(sDef.Content[4], "538686")
            });
            t.Content.Add(seg);

            //LX*1
            var lDef = (MapLoop)map.Content.First(s => s.Name == "L_LX");
            sDef = (MapSegment)lDef.Content.First(s => s.Name == "LX");

            EdiLoop lx = new EdiLoop(lDef, null);
            t.Content.Add(lx);

            seg = new EdiSegment(sDef);
            seg.Content.Add(new EdiDataElement(sDef.Content[0], "1"));
            lx.Content.Add(seg);

            //LX > W01 loop
            lDef = (MapLoop)lDef.Content.First(s => s.Name == "L_W01");
            sDef = (MapSegment)lDef.Content.First(s => s.Name == "W01");

            EdiLoop w01 = new EdiLoop(lDef, null);
            lx.Content.Add(w01);

            seg = new EdiSegment(sDef);
            seg.Content.AddRange(new[] {
                new EdiDataElement(sDef.Content[0], "12"),
                new EdiDataElement(sDef.Content[1], "CA"),
                new EdiDataElement(sDef.Content[1], "000100033330")
            });
            w01.Content.Add(seg);

            //LX*2
            lDef = (MapLoop)map.Content.First(s => s.Name == "L_LX");
            sDef = (MapSegment)lDef.Content.First(s => s.Name == "LX");

            lx = new EdiLoop(lDef, null);
            t.Content.Add(lx);

            seg = new EdiSegment(sDef);
            seg.Content.Add(new EdiDataElement(sDef.Content[0], "2"));
            lx.Content.Add(seg);

            //LX > W01 loop
            lDef = (MapLoop)lDef.Content.First(s => s.Name == "L_W01");
            sDef = (MapSegment)lDef.Content.First(s => s.Name == "W01");

            w01 = new EdiLoop(lDef, null);
            lx.Content.Add(w01);

            seg = new EdiSegment(sDef);
            seg.Content.AddRange(new[] {
                new EdiDataElement(sDef.Content[0], "10"),
                new EdiDataElement(sDef.Content[1], "CA"),
                new EdiDataElement(sDef.Content[1], "000100033332")
            });
            w01.Content.Add(seg);

            //create new batch, add interchange, group, transaction.
            EdiBatch b = new EdiBatch();
            b.Interchanges.Add(new EdiInterchange()
            {
                ElementSeparator = "*",
                SegmentSeparator = "\r\n"
            });
            b.Interchanges.First().Groups.Add(new EdiGroup("OW"));
            b.Interchanges.First().Groups.First().Transactions.Add(t);

            //Add all service segments
            EdiDataWriterSettings settings = new EdiDataWriterSettings(
                new SegmentDefinitions.ISA(), new SegmentDefinitions.IEA(),
                new SegmentDefinitions.GS(), new SegmentDefinitions.GE(),
                new SegmentDefinitions.ST(), new SegmentDefinitions.SE(),
                "ZZ", "SENDER", "ZZ", "RECEIVER", "GSSENDER", "GSRECEIVER",
                "00401", "004010", "T", 100, 200);

            EdiDataWriter w = new EdiDataWriter(settings);
            string data = w.WriteToString(b);


            //read produced results and check for errors.
            EdiDataReader r = new EdiDataReader();
            EdiBatch batch = new EdiBatch();
            r.FromString(data, ref batch);

            Assert.AreEqual(1, batch.Interchanges.Count);
            Assert.AreEqual(0, batch.Interchanges[0].ValidationErrors.Count());

            Assert.AreEqual(1, batch.Interchanges[0].Groups.Count);
            Assert.AreEqual(0, batch.Interchanges[0].Groups[0].ValidationErrors.Count());

            EdiTrans trans = batch.Interchanges[0].Groups[0].Transactions[0];
            Assert.AreEqual(0, trans.ValidationErrors.Count());
        }
    }
}
