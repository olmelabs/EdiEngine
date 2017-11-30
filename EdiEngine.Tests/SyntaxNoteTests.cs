using System.Collections.Generic;
using EdiEngine.Common.SyntaxNotes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EdiEngine.Tests
{
    [TestClass]
    public class SyntaxNoteTests
    {
        [TestMethod]
        public void SyntaxNote_Conditional()
        {
            //true
            List<string> content1 = new List<string>() {"01", "02", "03", "04", "05", "06"};
            List<string> content2 = new List<string>() {"01", "02"};
            List<string> content3 = new List<string>() {"01", "02", "", "04", "", "06" };

            //false
            List<string> content4 = new List<string>() { "01", "02", "03", "", "05", "06" };
            List<string> content5 = new List<string>() { "01", "02", "03", "04" };

            var syntaxNote = SyntaxNoteFactory.GetSyntaxNote("C030406");

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
    }
}
