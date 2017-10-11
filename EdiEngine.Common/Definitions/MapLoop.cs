using System.Collections.Generic;

namespace EdiEngine.Common.Definitions
{
    public abstract class MapLoop : MapBaseEntity
    {
        protected MapLoop(MapLoop parentLoop)
        {
            ParentLoop = parentLoop;
            MaxOccurs = 1000;
            Content = new List<MapBaseEntity>();
        }

        public List<MapBaseEntity> Content { get; }

        public MapLoop ParentLoop { get; }

        public int CurrentPos { get; set; }

        public override string EdiName => Name.Remove(0, 2);
    }
}
