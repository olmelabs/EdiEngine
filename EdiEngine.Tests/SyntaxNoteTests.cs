using System.Collections.Generic;
using System.IO;
using EdiEngine.Common.SyntaxNotes;
using EdiEngine.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EdiEngine.Tests
{
    [TestClass]
    public class SyntaxNoteTests
    {
        [TestMethod]
        public void SyntaxNote_Conditional()
        {
            //If the first element specified in the condition is present, then all others must be present

            //true
            List<string> content1 = new List<string>() {"01", "02", "03", "04", "05", "06"};
            List<string> content2 = new List<string>() {"01", "02"};
            List<string> content3 = new List<string>() {"01", "02", "", "04", "", "06" };

            //false
            List<string> content4 = new List<string>() { "01", "02", "03", "", "05", "06" };
            List<string> content5 = new List<string>() { "01", "02", "03", "04" };
            List<string> content6 = new List<string>() {"01", "02", "03"};

            var syntaxNote = SyntaxNoteFactory.GetSyntaxNote("C030406");

            bool res1 = syntaxNote.IsValid(content1.ToArray());
            bool res2 = syntaxNote.IsValid(content2.ToArray());
            bool res3 = syntaxNote.IsValid(content3.ToArray());
            bool res4 = syntaxNote.IsValid(content4.ToArray());
            bool res5 = syntaxNote.IsValid(content5.ToArray());
            bool res6 = syntaxNote.IsValid(content6.ToArray());

            Assert.IsTrue(res1);
            Assert.IsTrue(res2);
            Assert.IsTrue(res3);

            Assert.IsFalse(res4);
            Assert.IsFalse(res5);
            Assert.IsFalse(res6);
        }

        [TestMethod]
        public void SyntaxNote_Paired()
        {
            //If any element specified in the relational condition is present, then all must be present

            //true
            List<string> content1 = new List<string>() { "01", "02", "03", "04", "05", "06" };
            List<string> content2 = new List<string>() { "01", };
            List<string> content3 = new List<string>() { "01", "", "", "", "", "06" };

            //false
            List<string> content4 = new List<string>() { "01", "02", "03", "", "05", "06" };
            List<string> content5 = new List<string>() { "01", "", "03", "04" };
            List<string> content6 = new List<string>() {"01", "", "03"};

            var syntaxNote = SyntaxNoteFactory.GetSyntaxNote("P020304");

            bool res1 = syntaxNote.IsValid(content1.ToArray());
            bool res2 = syntaxNote.IsValid(content2.ToArray());
            bool res3 = syntaxNote.IsValid(content3.ToArray());
            bool res4 = syntaxNote.IsValid(content4.ToArray());
            bool res5 = syntaxNote.IsValid(content5.ToArray());
            bool res6 = syntaxNote.IsValid(content6.ToArray());

            Assert.IsTrue(res1);
            Assert.IsTrue(res2);
            Assert.IsTrue(res3);

            Assert.IsFalse(res4);
            Assert.IsFalse(res5);
            Assert.IsFalse(res6);
        }


        [TestMethod]
        public void SyntaxNote_Required()
        {
            //At least one specified in the relational condition must be present

            //true
            List<string> content1 = new List<string>() { "01", "02", "03", "04", "05", "06" };
            List<string> content2 = new List<string>() { "01", "02"};
            List<string> content3 = new List<string>() { "01", "", "", "04", "", "06" };

            //false
            List<string> content4 = new List<string>() { "01", "", "", "", "05", "06" };
            List<string> content5 = new List<string>() { "01"};

            var syntaxNote = SyntaxNoteFactory.GetSyntaxNote("R020304");

            bool res1 = syntaxNote.IsValid(content1.ToArray());
            bool res2 = syntaxNote.IsValid(content2.ToArray());
            bool res3 = syntaxNote.IsValid(content3.ToArray());
            bool res4 = syntaxNote.IsValid(content4.ToArray());
            bool res5 = syntaxNote.IsValid(content5.ToArray());

            Assert.IsTrue(res1);
            Assert.IsTrue(res2);
            Assert.IsTrue(res3);

            Assert.IsFalse(res4);
            Assert.IsFalse(res5);
        }

        [TestMethod]
        public void SyntaxNote_Exclusions()
        {
            //Not more than one can be present

            //true
            List<string> content1 = new List<string>() { "01", "02", "", "", "05", "06" };
            List<string> content2 = new List<string>() { "01", "02" };
            List<string> content3 = new List<string>() { "01", "", "", "04", "", "06" };
            List<string> content4 = new List<string>() { "01", "", "", "", "05", "06" };
            List<string> content5 = new List<string>() { "01" };

            //false
            List<string> content6 = new List<string>() { "01", "02", "03", "", "05", "06" };

            var syntaxNote = SyntaxNoteFactory.GetSyntaxNote("E020304");

            bool res1 = syntaxNote.IsValid(content1.ToArray());
            bool res2 = syntaxNote.IsValid(content2.ToArray());
            bool res3 = syntaxNote.IsValid(content3.ToArray());
            bool res4 = syntaxNote.IsValid(content4.ToArray());
            bool res5 = syntaxNote.IsValid(content5.ToArray());
            bool res6 = syntaxNote.IsValid(content6.ToArray());

            Assert.IsTrue(res1);
            Assert.IsTrue(res2);
            Assert.IsTrue(res3);
            Assert.IsTrue(res4);
            Assert.IsTrue(res5);
            Assert.IsFalse(res6);
        }

        [TestMethod]
        public void SyntaxNote_ListConditional()
        {
            //If the first element specified is present, then at least one of the remaining elements must be present

            //true
            List<string> content1 = new List<string>() { "01", "02", "03", "04", "", "06" };
            List<string> content2 = new List<string>() { "01", "02" };
            List<string> content3 = new List<string>() { "01", "02", "", "04", "", "06" };

            //false
            List<string> content4 = new List<string>() { "01", "02", "03", "", "", "", "07" };
            List<string> content5 = new List<string>() { "01", "02", "03"};

            var syntaxNote = SyntaxNoteFactory.GetSyntaxNote("L030406");

            bool res1 = syntaxNote.IsValid(content1.ToArray());
            bool res2 = syntaxNote.IsValid(content2.ToArray());
            bool res3 = syntaxNote.IsValid(content3.ToArray());
            bool res4 = syntaxNote.IsValid(content4.ToArray());
            bool res5 = syntaxNote.IsValid(content5.ToArray());

            Assert.IsTrue(res1);
            Assert.IsTrue(res2);
            Assert.IsTrue(res3);

            Assert.IsFalse(res4);
            Assert.IsFalse(res5);
        }

        [TestMethod]
        public void SyntaxNote_Edi850Fail()
        {
            using (Stream s = GetType().Assembly.GetManifestResourceStream("EdiEngine.Tests.TestData.850.SyntaxNotes.ERR.edi"))
            {
                EdiDataReader r = new EdiDataReader();
                EdiBatch b = r.FromStream(s);

                EdiTrans t = b.Interchanges[0].Groups[0].Transactions[0];

                Assert.AreEqual(3, t.ValidationErrors.Count);

                Assert.AreEqual(13, t.ValidationErrors[0].SegmentPos);
                Assert.IsTrue(t.ValidationErrors[0].Message.Contains("P0607"));

                Assert.AreEqual(30, t.ValidationErrors[1].SegmentPos);
                Assert.IsTrue(t.ValidationErrors[1].Message.Contains("C0506"));

                Assert.AreEqual(30, t.ValidationErrors[2].SegmentPos);
                Assert.IsTrue(t.ValidationErrors[2].Message.Contains("P0607"));
            }
        }
    }
}
