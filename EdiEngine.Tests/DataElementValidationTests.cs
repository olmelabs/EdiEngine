using Microsoft.VisualStudio.TestTools.UnitTesting;
using EdiEngine.Runtime;
using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;

namespace EdiEngine.Tests
{
    public class EAny : MapSimpleDataElement { }

    [TestClass]
    public class DataElementValidationTests
    {

        [TestMethod]
        public void Validation_RequiredMinMaxLen()
        {
            EAny def = new EAny()
            {
                DataType = DataType.AN,
                ReqDes = RequirementDesignator.Mandatory,
                MinLength = 2,
                MaxLength = 5,
            };

            var el = new EdiSimpleDataElement(def, "");
            Assert.IsFalse(el.IsValid(def));

            el = new EdiSimpleDataElement(def, "a");
            Assert.IsFalse(el.IsValid(def));

            el = new EdiSimpleDataElement(def, "abcdefg");
            Assert.IsFalse(el.IsValid(def));

            el = new EdiSimpleDataElement(def, "abcde");
            Assert.IsTrue(el.IsValid(def));
        }

        [TestMethod]
        public void Validation_OptionalMinMaxLen()
        {
            EAny def = new EAny()
            {
                DataType = DataType.AN,
                ReqDes = RequirementDesignator.Optional,
                MinLength = 2,
                MaxLength = 5,
            };

            var el = new EdiSimpleDataElement(def, "");
            Assert.IsTrue(el.IsValid(def));

            el = new EdiSimpleDataElement(def, "a");
            Assert.IsFalse(el.IsValid(def));

            el = new EdiSimpleDataElement(def, "abcdefg");
            Assert.IsFalse(el.IsValid(def));

            el = new EdiSimpleDataElement(def, "abcde");
            Assert.IsTrue(el.IsValid(def));
        }

        [TestMethod]
        public void Validation_OptionalDateTimeTest()
        {
            EAny def = new EAny()
            {
                DataType = DataType.DT,
                ReqDes = RequirementDesignator.Optional,
                MinLength = 6,
                MaxLength = 6,
            };

            EAny def2 = new EAny()
            {
                DataType = DataType.DT,
                ReqDes = RequirementDesignator.Optional,
                MinLength = 8,
                MaxLength = 8,
            };

            EAny def3 = new EAny()
            {
                DataType = DataType.TM,
                ReqDes = RequirementDesignator.Optional,
                MinLength = 4,
                MaxLength = 4,
            };

            var el = new EdiSimpleDataElement(def, "160102");
            Assert.IsTrue(el.IsValid(def));

            el = new EdiSimpleDataElement(def, "125566");
            Assert.IsFalse(el.IsValid(def));

            el = new EdiSimpleDataElement(def, "");
            Assert.IsTrue(el.IsValid(def));

            el = new EdiSimpleDataElement(def2, "20160102");
            Assert.IsTrue(el.IsValid(def2));

            el = new EdiSimpleDataElement(def2, "22125566");
            Assert.IsFalse(el.IsValid(def2));

            el = new EdiSimpleDataElement(def2, "");
            Assert.IsTrue(el.IsValid(def2));

            el = new EdiSimpleDataElement(def3, "1122");
            Assert.IsTrue(el.IsValid(def3));

            el = new EdiSimpleDataElement(def3, "4567");
            Assert.IsFalse(el.IsValid(def3));

            el = new EdiSimpleDataElement(def3, "");
            Assert.IsTrue(el.IsValid(def3));
        }

        [TestMethod]
        public void Validation_NumericTest()
        {
            EAny def = new EAny()
            {
                DataType = DataType.N0,
                ReqDes = RequirementDesignator.Optional,
                MinLength = 3,
                MaxLength = 6,
            };

            EAny def2 = new EAny()
            {
                DataType = DataType.N1,
                ReqDes = RequirementDesignator.Optional,
                MinLength = 3,
                MaxLength = 6,
            };

            EAny def3 = new EAny()
            {
                DataType = DataType.R,
                ReqDes = RequirementDesignator.Optional,
                MinLength = 3,
                MaxLength = 6,
            };

            var el = new EdiSimpleDataElement(def, "123");
            Assert.IsTrue(el.IsValid(def));

            el = new EdiSimpleDataElement(def, "12c");
            Assert.IsFalse(el.IsValid(def));

            el = new EdiSimpleDataElement(def, "");
            Assert.IsTrue(el.IsValid(def));

            el = new EdiSimpleDataElement(def2, "123");
            Assert.IsTrue(el.IsValid(def2));

            el = new EdiSimpleDataElement(def2, "12c");
            Assert.IsFalse(el.IsValid(def2));

            el = new EdiSimpleDataElement(def2, "");
            Assert.IsTrue(el.IsValid(def2));

            el = new EdiSimpleDataElement(def3, "123.23");
            Assert.IsTrue(el.IsValid(def3));

            el = new EdiSimpleDataElement(def3, "1233c");
            Assert.IsFalse(el.IsValid(def3));

            el = new EdiSimpleDataElement(def3, "");
            Assert.IsTrue(el.IsValid(def3));
        }

        [TestMethod]
        public void Validation_IdTest()
        {
            EAny def = new EAny()
            {
                DataType = DataType.ID,
                MinLength = 1,
                MaxLength = 1,
                ReqDes = RequirementDesignator.Optional
            };
            def.AllowedValues.AddRange(new[] { "C", "F", "N", "R" });

            var el = new EdiSimpleDataElement(def, "F");
            Assert.IsTrue(el.IsValid(def));

            el = new EdiSimpleDataElement(def, "Z");
            Assert.IsFalse(el.IsValid(def));

            el = new EdiSimpleDataElement(def, "");
            Assert.IsTrue(el.IsValid(def));
        }
    }
}