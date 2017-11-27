using EdiEngine.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace EdiEngine.Tests
{
    [TestClass]
    public class EdiReaderHLTests
    {
        [TestMethod]
        public void EdiReaderHL_ParseGenericEdi271()
        {
            using (Stream s = GetType().Assembly.GetManifestResourceStream("EdiEngine.Tests.TestData.271.edi"))
            {
                EdiDataReader r = new EdiDataReader();
                EdiBatch b = r.FromStream(s);

                EdiTrans t = b.Interchanges[0].Groups[0].Transactions[0];

                XmlDataWriter w = new XmlDataWriter();
                string data = w.WriteToString(b);
            }
        }
    }
}
