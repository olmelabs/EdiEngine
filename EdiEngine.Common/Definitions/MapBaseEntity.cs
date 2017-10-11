using EdiEngine.Common.Enums;

namespace EdiEngine.Common.Definitions
{
    public abstract class MapBaseEntity
    {
        protected MapBaseEntity()
        {
            Name = GetType().Name;
            ReqDes = RequirementDesignator.Optional;
        }

        public string Name { get; }

        public abstract string EdiName { get; }

        public RequirementDesignator ReqDes { get; set; }

        public int MaxOccurs { get; set; }

        public int OccuredTimes { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
