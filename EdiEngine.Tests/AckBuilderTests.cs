using System.IO;
using EdiEngine.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EdiEngine.Tests
{
    [TestClass]
    public class AckBuilderTests
    {
        [TestMethod]
        public void AckBuilder_Create997()
        {
            EdiBatch b;
            using (Stream s = GetType().Assembly.GetManifestResourceStream("EdiEngine.Tests.TestData.940_Failed_SE01.edi"))
            {
                EdiDataReader r = new EdiDataReader();
                b = r.FromStream(s);
            }

            AckBuilderSettings ackSettings = new AckBuilderSettings(AckValidationErrorBehavour.RejectValidationErrors, false);
            var ack = new AckBuilder(ackSettings);
            EdiBatch b997 = ack.GetnerateAcknowledgment(b);

            EdiDataWriterSettings settings = new EdiDataWriterSettings(
                new Standards.X12_004010.Segments.ISA(), new Standards.X12_004010.Segments.IEA(),
                new Standards.X12_004010.Segments.GS(), new Standards.X12_004010.Segments.GE(),
                new Standards.X12_004010.Segments.ST(), new Standards.X12_004010.Segments.SE(),
                "ZZ", "SENDER", "ZZ", "RECEIVER", "GSSENDER", "GSRECEIVER",
                "00401", "004010", "T", 100, 200, "\r\n", "*");

            EdiDataWriter w = new EdiDataWriter(settings);
            string data = w.WriteToString(b997);
        }
    }
}
