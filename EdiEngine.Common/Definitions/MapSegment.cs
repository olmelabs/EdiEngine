using System.Collections.Generic;

namespace EdiEngine.Common.Definitions
{
    public abstract class MapSegment : MapBaseEntity
    {
        protected MapSegment()
        {
            MaxOccurs = 1;
            Content = new List<MapDataElement>();
            SyntaxNotes = new List<string>();
        }

        public override string EdiName => Name;

        public List<MapDataElement> Content { get; }

        public List<string> SyntaxNotes { get; }

    }
}
