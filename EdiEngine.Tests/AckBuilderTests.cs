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
            //EdiBatch b997 = ack.GetnerateAcknowledgment(b);
            string a = ack.WriteAckToString(b, 100, 200);

        }
    }
}
