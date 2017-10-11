using System;
using System.Linq;
using EdiEngine.Common.Definitions;
using EdiEngine.Runtime;
using EdiEngine.Standards.X12_004010;
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
            EdiTrans t = new EdiTrans {Definition = map};

            // W05
            var sDef = (MapSegment) map.Content.First(s => s.Name == "W05");

            var seg = new EdiSegment(sDef);
            seg.Content.Add(new EdiDataElement(sDef.Content[0], "N"));
            seg.Content.Add(new EdiDataElement(sDef.Content[1], "538686"));
            seg.Content.Add(new EdiDataElement(sDef.Content[2], null));
            seg.Content.Add(new EdiDataElement(sDef.Content[3], "001001"));
            seg.Content.Add(new EdiDataElement(sDef.Content[4], "538686"));
            t.Content.Add(seg);

            // LX*1
            var lDef = (MapLoop)map.Content.First(s => s.Name == "L_LX");
            sDef = (MapSegment)lDef.Content.First(s => s.Name == "LX");

            EdiLoop lx = new EdiLoop(lDef, null);
            t.Content.Add(lx);

            seg = new EdiSegment(sDef);
            seg.Content.Add(new EdiDataElement(sDef.Content[0], "1"));
            lx.Content.Add(seg);

            lDef = (MapLoop)lDef.Content.First(s => s.Name == "L_W01");
            sDef = (MapSegment)lDef.Content.First(s => s.Name == "W01");

            EdiLoop w01 = new EdiLoop(lDef, null);
            lx.Content.Add(w01);

            seg = new EdiSegment(sDef);
            seg.Content.Add(new EdiDataElement(sDef.Content[0], "12"));
            seg.Content.Add(new EdiDataElement(sDef.Content[1], "CA"));
            seg.Content.Add(new EdiDataElement(sDef.Content[1], "000100033330"));         
            w01.Content.Add(seg);

            // LX*2
            lDef = (MapLoop)map.Content.First(s => s.Name == "L_LX");
            sDef = (MapSegment)lDef.Content.First(s => s.Name == "LX");

            lx = new EdiLoop(lDef, null);
            t.Content.Add(lx);

            seg = new EdiSegment(sDef);
            seg.Content.Add(new EdiDataElement(sDef.Content[0], "2"));
            lx.Content.Add(seg);

            lDef = (MapLoop)lDef.Content.First(s => s.Name == "L_W01");
            sDef = (MapSegment)lDef.Content.First(s => s.Name == "W01");

            w01 = new EdiLoop(lDef, null);
            lx.Content.Add(w01);

            seg = new EdiSegment(sDef);
            seg.Content.Add(new EdiDataElement(sDef.Content[0], "10"));
            seg.Content.Add(new EdiDataElement(sDef.Content[1], "CA"));
            seg.Content.Add(new EdiDataElement(sDef.Content[1], "000100033332"));
            w01.Content.Add(seg);

            EdiBatch b = new EdiBatch();
            b.Interchanges.Add(new EdiInterchange()
            {
                ElementSeparator = "*",
                SegmentSeparator = "\r\n"
            });
            b.Interchanges.First().Groups.Add(new EdiGroup());
            b.Interchanges.First().Groups.First().Transactions.Add(t);

            //TODO: finish with implementing ISA, GS, GE, IEA.
            //for now check it does not crash
            EdiDataWriter w = new EdiDataWriter();
            string data = w.WriteToString(b);
        }
    }
}
