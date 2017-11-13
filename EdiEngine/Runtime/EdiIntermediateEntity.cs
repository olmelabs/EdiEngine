using System.Collections.Generic;
using System.IO;

namespace EdiEngine.Runtime
{
    public class EdiIntermediateEntity
    {
        public EdiIntermediateEntity(EdiIntermediateEntity parent)
        {
            Parent = parent;
            Children = new List<EdiIntermediateEntity>();
        }

        public string Type { get; set; }
        public string Name { get; set; }
        public string E { get; set; }

        public EdiIntermediateEntity Parent { get; private set; }
        public List<EdiIntermediateEntity> Children { get; }

        public TokenContextType EntityType
        {
            get
            {
                switch (Type)
                {
                    case "L":
                        return TokenContextType.Loop;

                    case "S":
                        return TokenContextType.Segment;

                    case null:
                        return TokenContextType.DataElement;

                    default:
                        throw new InvalidDataException($"Enexpected Type found in Json {Type}");
                }
            }
        }
    }

    public enum TokenContextType
    {
        Loop,
        Segment,
        DataElement,
    }
}
