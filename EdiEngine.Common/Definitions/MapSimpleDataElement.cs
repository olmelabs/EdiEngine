using EdiEngine.Common.Enums;
using System.Collections.Generic;

namespace EdiEngine.Common.Definitions
{
    public abstract class MapSimpleDataElement : MapBaseDataElement
    {
        protected MapSimpleDataElement()
        {
            ReqDes = RequirementDesignator.Optional;
            AllowedValues = new List<string>();
        }

        public DataType DataType { get; set; }

        public int MinLength { get; set; }

        public int MaxLength { get; set; }

        public List<string> AllowedValues { get; }
    }
}
