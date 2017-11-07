using EdiEngine.Common.Definitions;


namespace EdiEngine
{
    public class AllowedEntitity
    {
        public AllowedEntitity(MapBaseEntity entity, MapLoop loopContext)
        {
            Entity = entity;
            LoopContext = loopContext;
        }

        public MapBaseEntity Entity { get; }
        public MapLoop LoopContext { get; }

        public override string ToString()
        {
            return $"{Entity.Name} - {LoopContext.Name}";
        }
    }
}
