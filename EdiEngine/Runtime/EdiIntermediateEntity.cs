using System.Collections.Generic;
using System.IO;
using System.Linq;

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

                    case "C":
                        return TokenContextType.CompositeDataElement;

                    case null:
                        return TokenContextType.SimpleDataElement;

                    default:
                        throw new InvalidDataException($"Enexpected Type found in Json {Type}");
                }
            }
        }

        public override string ToString()
        {
            switch (EntityType)
            {
                case TokenContextType.SimpleDataElement:
                    return E;

                case TokenContextType.CompositeDataElement:
                    return string.Join(EdiInterchange.DefaultCompositeSeparator, Children.Select(c => c.E));

                default:
                    return base.ToString();

            }
        }
    }

    public enum TokenContextType
    {
        Loop,
        Segment,
        CompositeDataElement,
        SimpleDataElement,
    }
}
