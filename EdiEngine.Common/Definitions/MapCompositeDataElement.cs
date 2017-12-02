using System.Collections.Generic;
using EdiEngine.Common.Enums;

namespace EdiEngine.Common.Definitions
{
    public class MapCompositeDataElement : MapBaseDataElement
    {
        public MapCompositeDataElement()
        {
            ReqDes = RequirementDesignator.Optional;
            Content = new List<MapDataElement>();
        }

        public List<MapDataElement> Content { get; }
    }
}
