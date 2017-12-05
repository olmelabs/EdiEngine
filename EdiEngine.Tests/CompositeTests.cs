
using System.IO;
using EdiEngine.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EdiEngine.Tests
{

    [TestClass]
    public class CompositeTests
    {
        [TestMethod]
        public void Composite_ParseOk()
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
