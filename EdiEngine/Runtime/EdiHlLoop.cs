using EdiEngine.Common.Definitions;

namespace EdiEngine.Runtime
{
    public class EdiHlLoop : EdiLoop
    {
        public EdiHlLoop(MapBaseEntity definition, 
            EdiLoop parent, 
            int HL01,
            int? HL02
            ) : base(definition, parent)
        {
            HL01_HierarchicalIdNumber = HL01;
            HL02_HierarchicalParentIdNumber = HL02;
        }

        int HL01_HierarchicalIdNumber { get; }

        int? HL02_HierarchicalParentIdNumber { get; }
    }
}
