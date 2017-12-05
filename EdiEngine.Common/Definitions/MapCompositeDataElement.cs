using System.Collections.Generic;
using EdiEngine.Common.Enums;

namespace EdiEngine.Common.Definitions
{
    public class MapCompositeDataElement : MapBaseDataElement
    {
        public MapCompositeDataElement()
        {
            Name = GetType().Name;
            ReqDes = RequirementDesignator.Optional;
            Content = new List<MapSimpleDataElement>();
        }

        public string Name { get; }

        public List<MapSimpleDataElement> Content { get; }
    }
}
