using System.IO;
using System.Linq;
using EdiEngine.Runtime;
using SegmentDefinitions = EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Tests
{
    public class TestUtils
    {
        public static string ReadResourceStream(string resourceName)
        {
            using (var s = typeof(TestUtils).Assembly.GetManifestResourceStream(resourceName))
            {
                if (s == null)
                    throw new InvalidDataException("stream is null");

                using (StreamReader sr = new StreamReader(s))
                {
                    return sr.ReadToEnd();
                }
            }
        }

        public static string WriteEdiEnvelope(EdiTrans t, string functionalCode)
        {
            //create batch
            EdiBatch b = new EdiBatch();
            b.Interchanges.Add(new EdiInterchange());
            b.Interchanges.First().Groups.Add(new EdiGroup(functionalCode));
            b.Interchanges.First().Groups.First().Transactions.Add(t);

            //Add all service segments
            EdiDataWriterSettings settings = new EdiDataWriterSettings(
                new SegmentDefinitions.ISA(), new SegmentDefinitions.IEA(),
                new SegmentDefinitions.GS(), new SegmentDefinitions.GE(),
                new SegmentDefinitions.ST(), new SegmentDefinitions.SE(),
                "ZZ", "SENDER", "ZZ", "RECEIVER", "GSSENDER", "GSRECEIVER",
                "00401", "004010", "T", 100, 200, "\r\n", "*");

            EdiDataWriter w = new EdiDataWriter(settings);
            return  w.WriteToString(b);
        }
    }
}
