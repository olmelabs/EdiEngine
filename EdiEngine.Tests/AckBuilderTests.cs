using System.IO;
using System.Linq;
using EdiEngine.Common.Definitions;
using EdiEngine.Runtime;
using EdiEngine.Standards.X12_004010.Maps;
using EdiEngine.Standards.X12_004010.Segments;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EdiEngine.Tests
{
    [TestClass]
    public class AckBuilderTests
    {
        [TestMethod]
        public void AckBuilder_AcceptAll_NoAk2()
        {
            EdiBatch b;
            using (Stream s = GetType().Assembly.GetManifestResourceStream("EdiEngine.Tests.TestData.AckTest.edi"))
            {
                EdiDataReader r = new EdiDataReader();
                b = r.FromStream(s);
            }

            AckBuilderSettings ackSettings = new AckBuilderSettings(AckValidationErrorBehavour.AcceptAll, false, 100, 200);
            var ack = new AckBuilder(ackSettings);

            EdiBatch ackBatch = ack.GetnerateAcknowledgment(b);
            //string data = ack.WriteToString(b);

            EdiTrans ack1 = ackBatch.Interchanges[0].Groups[0].Transactions[0];
            EdiTrans ack2 = ackBatch.Interchanges[0].Groups[1].Transactions[0];

            EdiSegment ak1 = (EdiSegment)ack1.Content.FirstOrDefault(l => l.Definition.GetType() == typeof(AK1));
            EdiLoop loopAk2 = (EdiLoop)ack1.Content.FirstOrDefault(l => l.Definition.GetType() == typeof(M_997.L_AK2));
            EdiSegment ak9 = (EdiSegment)ack1.Content.FirstOrDefault(l => l.Definition.GetType() == typeof(AK9));

            Assert.IsNotNull(ak1);
            Assert.IsNull(loopAk2);
            Assert.IsNotNull(ak9);
            Assert.AreEqual("A", ak9.Content[0].Val);
            Assert.AreEqual("2", ak9.Content[1].Val);
            Assert.AreEqual("2", ak9.Content[2].Val);
            Assert.AreEqual("2", ak9.Content[3].Val);

            ak1 = (EdiSegment)ack2.Content.FirstOrDefault(l => l.Definition.GetType() == typeof(AK1));
            loopAk2 = (EdiLoop)ack2.Content.FirstOrDefault(l => l.Definition.GetType() == typeof(M_997.L_AK2));
            ak9 = (EdiSegment)ack2.Content.FirstOrDefault(l => l.Definition.GetType() == typeof(AK9));

            Assert.IsNotNull(ak1);
            Assert.IsNull(loopAk2);
            Assert.IsNotNull(ak9);
            Assert.AreEqual("A", ak9.Content[0].Val);
            Assert.AreEqual("1", ak9.Content[1].Val);
            Assert.AreEqual("1", ak9.Content[2].Val);
            Assert.AreEqual("1", ak9.Content[3].Val);
        }

        [TestMethod]
        public void AckBuilder_AcceptAll_WithAk2()
        {
            EdiBatch b;
            using (Stream s = GetType().Assembly.GetManifestResourceStream("EdiEngine.Tests.TestData.AckTest.edi"))
            {
                EdiDataReader r = new EdiDataReader();
                b = r.FromStream(s);
            }

            AckBuilderSettings ackSettings = new AckBuilderSettings(AckValidationErrorBehavour.AcceptAll, true, 100, 200);
            var ack = new AckBuilder(ackSettings);

            EdiBatch ackBatch = ack.GetnerateAcknowledgment(b);
            //string data = ack.WriteToString(b);

            EdiTrans ack1 = ackBatch.Interchanges[0].Groups[0].Transactions[0];
            EdiTrans ack2 = ackBatch.Interchanges[0].Groups[1].Transactions[0];

            EdiSegment ak1 = (EdiSegment)ack1.Content.FirstOrDefault(l => l.Definition.GetType() == typeof(AK1));
            EdiLoop loopAk2_1 = (EdiLoop)ack1.Content.FirstOrDefault(l => l.Definition.GetType() == typeof(M_997.L_AK2));
            EdiLoop loopAk2_2 = (EdiLoop)ack1.Content.LastOrDefault(l => l.Definition.GetType() == typeof(M_997.L_AK2));
            EdiSegment ak5_1 = (EdiSegment)loopAk2_1.Content.FirstOrDefault(l => l.Definition.GetType() == typeof(AK5));
            EdiSegment ak5_2 = (EdiSegment)loopAk2_2.Content.FirstOrDefault(l => l.Definition.GetType() == typeof(AK5));
            EdiSegment ak9 = (EdiSegment)ack1.Content.FirstOrDefault(l => l.Definition.GetType() == typeof(AK9));

            Assert.IsNotNull(ak1);
            Assert.IsNotNull(loopAk2_1);
            Assert.AreEqual("A", ak5_1.Content[0].Val);
            Assert.AreEqual("A", ak5_2.Content[0].Val);
            Assert.IsNotNull(loopAk2_2);
            Assert.IsNotNull(ak9);
            Assert.AreEqual("A", ak9.Content[0].Val);
            Assert.AreEqual("2", ak9.Content[1].Val);
            Assert.AreEqual("2", ak9.Content[2].Val);
            Assert.AreEqual("2", ak9.Content[3].Val);

            ak1 = (EdiSegment)ack2.Content.FirstOrDefault(l => l.Definition.GetType() == typeof(AK1));
            loopAk2_1 = (EdiLoop)ack1.Content.FirstOrDefault(l => l.Definition.GetType() == typeof(M_997.L_AK2));
            ak5_1 = (EdiSegment)loopAk2_1.Content.FirstOrDefault(l => l.Definition.GetType() == typeof(AK5));
            ak9 = (EdiSegment)ack2.Content.FirstOrDefault(l => l.Definition.GetType() == typeof(AK9));

            Assert.IsNotNull(ak1);
            Assert.IsNotNull(loopAk2_1);
            Assert.AreEqual("A", ak5_1.Content[0].Val);
            Assert.IsNotNull(ak9);
            Assert.AreEqual("A", ak9.Content[0].Val);
            Assert.AreEqual("1", ak9.Content[1].Val);
            Assert.AreEqual("1", ak9.Content[2].Val);
            Assert.AreEqual("1", ak9.Content[3].Val);
        }

        [TestMethod]
        public void AckBuilder_AcceptButNoteErrors()
        {
            EdiBatch b;
            using (Stream s = GetType().Assembly.GetManifestResourceStream("EdiEngine.Tests.TestData.AckTest.edi"))
            {
                EdiDataReader r = new EdiDataReader();
                b = r.FromStream(s);
            }

            AckBuilderSettings ackSettings = new AckBuilderSettings(AckValidationErrorBehavour.AcceptButNoteErrors, false, 100, 200);
            var ack = new AckBuilder(ackSettings);

            EdiBatch ackBatch = ack.GetnerateAcknowledgment(b);
            //string data = ack.WriteToString(b);

            EdiTrans ack1 = ackBatch.Interchanges[0].Groups[0].Transactions[0];
            EdiTrans ack2 = ackBatch.Interchanges[0].Groups[1].Transactions[0];

            EdiSegment ak1 = (EdiSegment)ack1.Content.FirstOrDefault(l => l.Definition.GetType() == typeof(AK1));
            EdiLoop loopAk2_1 = (EdiLoop)ack1.Content.FirstOrDefault(l => l.Definition.GetType() == typeof(M_997.L_AK2));
            EdiLoop loopAk2_2 = (EdiLoop)ack1.Content.LastOrDefault(l => l.Definition.GetType() == typeof(M_997.L_AK2));
            EdiSegment ak5_1 = (EdiSegment)loopAk2_1.Content.FirstOrDefault(l => l.Definition.GetType() == typeof(AK5));
            EdiSegment ak5_2 = (EdiSegment)loopAk2_2.Content.FirstOrDefault(l => l.Definition.GetType() == typeof(AK5));
            EdiSegment ak9 = (EdiSegment)ack1.Content.FirstOrDefault(l => l.Definition.GetType() == typeof(AK9));

            Assert.IsNotNull(ak1);
            Assert.IsNotNull(loopAk2_1);
            Assert.AreEqual("A", ak5_1.Content[0].Val);
            Assert.AreEqual("E", ak5_2.Content[0].Val);
            Assert.IsNotNull(loopAk2_2);
            Assert.IsNotNull(ak9);
            Assert.AreEqual("E", ak9.Content[0].Val);
            Assert.AreEqual("2", ak9.Content[1].Val);
            Assert.AreEqual("2", ak9.Content[2].Val);
            Assert.AreEqual("2", ak9.Content[3].Val);

            ak1 = (EdiSegment)ack2.Content.FirstOrDefault(l => l.Definition.GetType() == typeof(AK1));
            loopAk2_1 = (EdiLoop)ack2.Content.FirstOrDefault(l => l.Definition.GetType() == typeof(M_997.L_AK2));
            ak5_1 = (EdiSegment)loopAk2_1.Content.FirstOrDefault(l => l.Definition.GetType() == typeof(AK5));
            ak9 = (EdiSegment)ack2.Content.FirstOrDefault(l => l.Definition.GetType() == typeof(AK9));

            Assert.IsNotNull(ak1);
            Assert.IsNotNull(loopAk2_1);
            Assert.AreEqual("E", ak5_1.Content[0].Val);
            Assert.IsNotNull(ak9);
            Assert.AreEqual("E", ak9.Content[0].Val);
            Assert.AreEqual("1", ak9.Content[1].Val);
            Assert.AreEqual("1", ak9.Content[2].Val);
            Assert.AreEqual("1", ak9.Content[3].Val);
        }

        [TestMethod]
        public void AckBuilder_RejectIfValidationErrors()
        {
            EdiBatch b;
            using (Stream s = GetType().Assembly.GetManifestResourceStream("EdiEngine.Tests.TestData.AckTest.edi"))
            {
                EdiDataReader r = new EdiDataReader();
                b = r.FromStream(s);
            }

            AckBuilderSettings ackSettings = new AckBuilderSettings(AckValidationErrorBehavour.RejectValidationErrors, false, 100, 200);
            var ack = new AckBuilder(ackSettings);

            EdiBatch ackBatch = ack.GetnerateAcknowledgment(b);
            string data = ack.WriteToString(b);

            EdiTrans ack1 = ackBatch.Interchanges[0].Groups[0].Transactions[0];
            EdiTrans ack2 = ackBatch.Interchanges[0].Groups[1].Transactions[0];

            EdiSegment ak1 = (EdiSegment)ack1.Content.FirstOrDefault(l => l.Definition.GetType() == typeof(AK1));
            EdiLoop loopAk2_1 = (EdiLoop)ack1.Content.FirstOrDefault(l => l.Definition.GetType() == typeof(M_997.L_AK2));
            EdiLoop loopAk2_2 = (EdiLoop)ack1.Content.LastOrDefault(l => l.Definition.GetType() == typeof(M_997.L_AK2));
            EdiSegment ak5_1 = (EdiSegment)loopAk2_1.Content.FirstOrDefault(l => l.Definition.GetType() == typeof(AK5));
            EdiSegment ak5_2 = (EdiSegment)loopAk2_2.Content.FirstOrDefault(l => l.Definition.GetType() == typeof(AK5));
            EdiSegment ak9 = (EdiSegment)ack1.Content.FirstOrDefault(l => l.Definition.GetType() == typeof(AK9));

            Assert.IsNotNull(ak1);
            Assert.IsNotNull(loopAk2_1);
            Assert.AreEqual("A", ak5_1.Content[0].Val);
            Assert.AreEqual("R", ak5_2.Content[0].Val);
            Assert.IsNotNull(loopAk2_2);
            Assert.IsNotNull(ak9);
            Assert.AreEqual("P", ak9.Content[0].Val);
            Assert.AreEqual("2", ak9.Content[1].Val);
            Assert.AreEqual("2", ak9.Content[2].Val);
            Assert.AreEqual("1", ak9.Content[3].Val);

            ak1 = (EdiSegment)ack2.Content.FirstOrDefault(l => l.Definition.GetType() == typeof(AK1));
            loopAk2_1 = (EdiLoop)ack2.Content.FirstOrDefault(l => l.Definition.GetType() == typeof(M_997.L_AK2));
            ak5_1 = (EdiSegment)loopAk2_1.Content.FirstOrDefault(l => l.Definition.GetType() == typeof(AK5));
            ak9 = (EdiSegment)ack2.Content.FirstOrDefault(l => l.Definition.GetType() == typeof(AK9));

            Assert.IsNotNull(ak1);
            Assert.IsNotNull(loopAk2_1);
            Assert.AreEqual("R", ak5_1.Content[0].Val);
            Assert.IsNotNull(ak9);
            Assert.AreEqual("R", ak9.Content[0].Val);
            Assert.AreEqual("1", ak9.Content[1].Val);
            Assert.AreEqual("1", ak9.Content[2].Val);
            Assert.AreEqual("0", ak9.Content[3].Val);
        }
    }
}

