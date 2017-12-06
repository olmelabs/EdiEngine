using System.Collections.Generic;
using System.Linq;
using EdiEngine.Common.Definitions;
using EdiEngine.Runtime;
using EdiEngine.Validation;

namespace EdiEngine
{
    public abstract class InetermediateFormatReader : MapReader
    {
        protected EdiTrans Trans;
        protected EdiLoop CurrentLoopInstance;
        protected MapLoop CurrentLoopDef;
        protected MapBaseEntity CurrentEntityDef;

        protected InetermediateFormatReader(MapLoop map)
        {
            CurrentLoopDef = map;
        }

        protected abstract EdiIntermediateEntity ReadIntermediateTree(string rawData);

        public virtual EdiTrans ReadToEnd(string rawData)
        {
            Trans = new EdiTrans(CurrentLoopDef);

            CurrentLoopInstance = Trans;
            CurrentLoopInstance.Definition = CurrentLoopDef;

            EdiIntermediateEntity intermediateTree = ReadIntermediateTree(rawData);

            ParseTree(intermediateTree);

            return Trans;
        }

        protected virtual void ParseTree(EdiIntermediateEntity intermediateStructure)
        {
            foreach (EdiIntermediateEntity ent in intermediateStructure.Children)
            {
                switch (ent.EntityType)
                {
                    case TokenContextType.Loop:
                        SetMapContext(ent.Name);
                        ParseTree(ent);
                        break;

                    case TokenContextType.Segment:
                        SetMapContext(ent.Name);

                        if (ent.Parent != null && !ent.Parent.Name.Equals(CurrentLoopDef.Name))
                        {
                            ValidationError err = new ValidationError()
                            {
                                Message = $"Unexpected Segment at {ent.Parent.Name} > {ent.Name}."
                            };
                            Trans.ValidationErrors.Add(err);
                        }

                        List<string> segParts = new List<string> { ent.Name };
                        segParts.AddRange(ent.Children.Select(el => el.ToString()));

                        EdiSegment seg = ProcessSegment(CurrentEntityDef, segParts.ToArray(), -1, EdiInterchange.DefaultCompositeSeparator, Trans);
                        CurrentLoopInstance.Content.Add(seg);
                        break;
                }
            }
        }

        //TODO:Refactor to make same code base with EdiMapReader.ProcessRawSegment
        protected void SetMapContext(string name)
        {
            List<AllowedEntitity> allowedEntities = GetNextAllowedEntities(CurrentLoopDef);

            if (allowedEntities.All(e => e.Entity.Name != name))
            {
                string expected = string.Join(", ", allowedEntities.Select(e => e.Entity.Name).ToList());
                string msgPart = allowedEntities.Count > 1 ? "Expected one of" : "Expected";
                ValidationError err = new ValidationError()
                {
                    Message = $"Unexpected Segment. {msgPart} {expected}. Found {name}."
                };
                Trans.ValidationErrors.Add(err);
                return;
            }

            AllowedEntitity ae = allowedEntities.FirstOrDefault(e => e.Entity.Name == name);
            if (ae?.Entity is MapSegment)
            {
                ae.Entity.OccuredTimes++;

                CurrentLoopDef = ae.LoopContext;
                CurrentLoopDef.CurrentPos = CurrentLoopDef.Content.IndexOf(ae.Entity);

                while (((MapLoop)CurrentLoopInstance.Definition) != ae.LoopContext && CurrentLoopInstance.Parent != null)
                {
                    CurrentLoopInstance = CurrentLoopInstance.Parent;
                }

                CurrentEntityDef = ae.Entity;
            }
            else if (ae?.Entity is MapLoop)
            {
                //find loop definition in map and reset counters
                ae.LoopContext.CurrentPos = ae.LoopContext.Content.IndexOf(ae.Entity);
                CurrentLoopDef = (MapLoop)ae.Entity;
                CurrentLoopDef.CurrentPos = 0;
                CurrentLoopDef.OccuredTimes++;
                CurrentLoopDef.Content.ForEach(c => c.OccuredTimes = 0);

                ////create new loop instance and add to transaction
                while (((MapLoop)CurrentLoopInstance.Definition) != ae.LoopContext && CurrentLoopInstance.Parent != null)
                {
                    CurrentLoopInstance = CurrentLoopInstance.Parent;
                }

                var newLoop = new EdiLoop(ae.Entity, CurrentLoopInstance);
                CurrentLoopInstance.Content.Add(newLoop);
                CurrentLoopInstance = newLoop;
            }
        }
    }
}
