using System;
using System.Globalization;
using EdiEngine.Common.Definitions;
using EdiEngine.Common.Enums;
using EdiEngine.Runtime;

namespace EdiEngine.Validation
{
    public static class DataElementExtensions
    {
        public static bool IsValid(this EdiSimpleDataElement el, MapSimpleDataElement definition)
        {
            //required
            if (definition.ReqDes == RequirementDesignator.Mandatory && string.IsNullOrEmpty(el.Val)) //whitespaces allowed
                return false;

            //Min max len
            if (!string.IsNullOrEmpty(el.Val) && (el.Val.Length < definition.MinLength || el.Val.Length > definition.MaxLength))
                return false;

            DateTime dummyDt;

            switch (definition.DataType)
            {
                case DataType.B:
                case DataType.AN:
                    return true;

                case DataType.ID:
                    return definition.AllowedValues.IndexOf(el.Val) >= 0 ||
                        (definition.ReqDes == RequirementDesignator.Optional && string.IsNullOrEmpty(el.Val));

                case DataType.N0:
                case DataType.N1:
                case DataType.N2:
                case DataType.N4:
                case DataType.N6:
                    int dummyInt;
                    return int.TryParse(el.Val, out dummyInt) ||
                        (definition.ReqDes == RequirementDesignator.Optional && string.IsNullOrEmpty(el.Val));

                case DataType.R:
                case DataType.R2:
                case DataType.R4:
                case DataType.R5:
                case DataType.R6:
                case DataType.R7:
                case DataType.R8:
                case DataType.R9:
                    decimal dummyDec;
                    return decimal.TryParse(el.Val, out dummyDec) ||
                        (definition.ReqDes == RequirementDesignator.Optional && string.IsNullOrEmpty(el.Val));

                case DataType.DT:
                    switch (definition.MaxLength)
                    {
                        case 6:
                            return DateTime.TryParseExact(el.Val, "yyMMdd", CultureInfo.InvariantCulture,
                                DateTimeStyles.None, out dummyDt) ||
                                (definition.ReqDes == RequirementDesignator.Optional && string.IsNullOrEmpty(el.Val));

                        case 8:
                            return DateTime.TryParseExact(el.Val, "yyyyMMdd", CultureInfo.InvariantCulture,
                                DateTimeStyles.None, out dummyDt) ||
                                (definition.ReqDes == RequirementDesignator.Optional && string.IsNullOrEmpty(el.Val));

                        default:
                            throw new NotSupportedException($"Date validation with length {definition.MaxLength} is not implemented. {el.Type}");
                    }

                case DataType.TM:
                    return DateTime.TryParseExact(el.Val, "HHmm", CultureInfo.InvariantCulture, DateTimeStyles.None, out dummyDt) ||
                        (definition.ReqDes == RequirementDesignator.Optional && string.IsNullOrEmpty(el.Val));

                default:
                    throw new NotSupportedException($"{definition.DataType} validation is not implemented. {el.Type}");
            }
        }
    }
}
