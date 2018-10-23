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

            switch (definition.DataType)
            {
                case DataType.B:
                case DataType.AN:
                    return true;

                case DataType.ID:
                    return definition.AllowedValues.IndexOf(el.Val) >= 0 || IsOptional(el.Val, definition);

                case DataType.N0:
                case DataType.N1:
                case DataType.N2:
                case DataType.N4:
                case DataType.N6:
                    int dummyInt;
                    return int.TryParse(el.Val, out dummyInt) || IsOptional(el.Val, definition);

                case DataType.R:
                case DataType.R2:
                case DataType.R4:
                case DataType.R5:
                case DataType.R6:
                case DataType.R7:
                case DataType.R8:
                case DataType.R9:
                    decimal dummyDec;
                    return decimal.TryParse(el.Val, out dummyDec) || IsOptional(el.Val, definition);

                case DataType.DT:
                    switch (definition.MaxLength)
                    {
                        case 6:
                            return ValidateShortDate(el, definition); 

                        case 8:
                            return ValidateLongDate(el, definition);

                        default:
                            throw new NotSupportedException($"Date validation with length {definition.MaxLength} is not implemented. {el.Type}");
                    }

                case DataType.TM:
                    switch (definition.MaxLength)
                    {
                        case 4:
                            return ValidateShortTime(el, definition);
                        case 8:
                            return ValidateLongTime(el, definition);
                        default:
                            throw new NotSupportedException($"Time validation with length {definition.MaxLength} is not implemented. {el.Type}");
                    }
                default:
                    throw new NotSupportedException($"{definition.DataType} validation is not implemented. {el.Type}");
            }
        }

        #region PrivateHelpers

        private static bool ValidateLongDate(EdiSimpleDataElement el, MapSimpleDataElement definition)
        {
            if (string.IsNullOrEmpty(el.Val))
                return IsOptional(el.Val, definition);

            return el.Val.IsValidDateTimeString("yyyyMMdd");
        }

        private static bool ValidateShortDate(EdiSimpleDataElement el, MapSimpleDataElement definition)
        {
            if (string.IsNullOrEmpty(el.Val))
                return IsOptional(el.Val, definition);

            return el.Val.IsValidDateTimeString("yyMMdd");
        }

        private static bool ValidateShortTime(EdiSimpleDataElement el, MapSimpleDataElement definition)
        {
            if (string.IsNullOrEmpty(el.Val))
                return IsOptional(el.Val, definition);

            switch (el.Val.Length)
            {
                case 4:
                    return el.Val.IsValidDateTimeString("HHmm");

                default:
                    throw new NotSupportedException($"Time validation with length {el.Val.Length} is not implemented. {el.Type}");
            }
        }

        private static bool ValidateLongTime(EdiSimpleDataElement el, MapSimpleDataElement definition)
        {
            if (string.IsNullOrEmpty(el.Val))
                return IsOptional(el.Val, definition);

            switch (el.Val.Length)
            {
                case 4:
                    return ValidateShortTime(el, definition);
                case 5:
                    return el.Val.IsValidDateTimeString("HHmms");
                case 6:
                    return el.Val.IsValidDateTimeString("HHmmss");
                case 7:
                    return el.Val.IsValidDateTimeString("HHmmssf");
                case 8:
                    return el.Val.IsValidDateTimeString("HHmmssff");
                default:
                    throw new NotSupportedException($"Time validation with length {el.Val.Length} is not implemented. {el.Type}");
            }
        }

        private static bool IsValidDateTimeString(this string dateTime, string format)
        {
            DateTime dummyDt;
            return DateTime.TryParseExact(dateTime, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out dummyDt);
        }

        private static bool IsOptional(string value, MapSimpleDataElement definition)
        {
            return definition.ReqDes == RequirementDesignator.Optional && string.IsNullOrEmpty(value);
        }
        #endregion
    }
}
