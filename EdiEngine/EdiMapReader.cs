using EdiEngine.Common.Definitions;
using EdiEngine.Common.Enums;
using EdiEngine.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EdiEngine
{
    public class EdiMapReader
    {
        private readonly EdiTrans _trans;
        private EdiLoop _currentLoopInstance;
        private MapLoop _currentLoopDef;

        public EdiMapReader(MapLoop map, EdiTrans currentTrans)
        {
            _trans = currentTrans;
            _currentLoopInstance = currentTrans;
            _currentLoopInstance.Definition = map;
            _currentLoopDef = map;
        }

        public void ProcessRawSegment(string name, string[] content, int rowPos)
        {
            List<AllowedEntitity> allowedEntities = GetNextAllowedEntities(_currentLoopDef);

            if (allowedEntities.All(e => e.Entity.EdiName != name))
            {
                string expected = string.Join(", ", allowedEntities.Select(e => e.Entity.Name).ToList());
                string msgPart = allowedEntities.Count > 1 ? "Expected one of" : "Expected";
                ValidationError err = new ValidationError()
                {
                    SegmentPos = rowPos,
                    SegmentName = name,
                    Message = $"Unexpected Segment. {msgPart} {expected}. Found {name}."
                };
                _trans.ValidationErrors.Add(err);
                return;
            }

            AllowedEntitity ae = allowedEntities.FirstOrDefault(e => e.Entity.EdiName == name);
            if (ae?.Entity is MapSegment)
            {
                ae.Entity.OccuredTimes++;

                _currentLoopDef = ae.LoopContext;
                _currentLoopDef.CurrentPos = _currentLoopDef.Content.IndexOf(ae.Entity);

                while (((MapLoop)_currentLoopInstance.Definition) != ae.LoopContext && _currentLoopInstance.Parent != null)
                {
                    _currentLoopInstance = _currentLoopInstance.Parent;
                }
                _currentLoopInstance.Content.Add(ProcessSegment(ae.Entity, content, rowPos, _trans));
            }
            else if (ae?.Entity is MapLoop)
            {
                //find loop definition in map and reset counters
                ae.LoopContext.CurrentPos = ae.LoopContext.Content.IndexOf(ae.Entity);
                _currentLoopDef = (MapLoop)ae.Entity;
                _currentLoopDef.CurrentPos = 0;
                _currentLoopDef.OccuredTimes++;
                _currentLoopDef.Content.ForEach(c => c.OccuredTimes = 0);

                //create new loop instance and add to transaction
                while (((MapLoop)_currentLoopInstance.Definition) != ae.LoopContext && _currentLoopInstance.Parent != null)
                {
                    _currentLoopInstance = _currentLoopInstance.Parent;
                }

                var newLoop = new EdiLoop(ae.Entity, _currentLoopInstance);
                _currentLoopInstance.Content.Add(newLoop);
                _currentLoopInstance = newLoop;

                ProcessRawSegment(name, content, rowPos);
            }

        }

        public static EdiSegment ProcessSegment(MapBaseEntity definition, string[] content, int rowPos, IValidatedEntity validationScope)
        {
            MapSegment segDef = (MapSegment)definition;
            EdiSegment seg = new EdiSegment(segDef);

            int i = 0;
            foreach (string val in content.Skip(1))
            {
                MapDataElement elDef = null;
                if (i < segDef.Content.Count)
                    elDef = segDef.Content[i];

                if (elDef == null)
                {
                    ValidationError err = new ValidationError()
                    {
                        SegmentPos = rowPos,
                        SegmentName = content[0],
                        ElementPos = i + 1,
                        Message = $"Unexpected element '{val}'"
                    };
                    validationScope.ValidationErrors.Add(err);
                }
                
                EdiDataElement el = new EdiDataElement(elDef, val);
                if (elDef != null && !el.IsValid(elDef))
                {
                    ValidationError err = new ValidationError()
                    {
                        SegmentPos = rowPos,
                        SegmentName = content[0],
                        ElementPos = i + 1,
                        Message = $"Invalid value '{val}'"
                    };
                    validationScope.ValidationErrors.Add(err);
                }

                i++;
                seg.Content.Add(el);
            }
            return seg;
        }

        private List<AllowedEntitity> GetNextAllowedEntities(MapLoop currentLoop)
        {
            List<AllowedEntitity> res = new List<AllowedEntitity>();
            MapBaseEntity be = currentLoop.Content[currentLoop.CurrentPos];

            if (be.ReqDes == RequirementDesignator.Mandatory && be.OccuredTimes == 0)
            {
                res.Add(new AllowedEntitity(be, currentLoop));
                return res;
            }

            if (be.OccuredTimes > 0 && be.OccuredTimes < be.MaxOccurs)
            {
                res.Add(new AllowedEntitity(be, currentLoop));
            }

            for (int i = currentLoop.CurrentPos + 1; i < currentLoop.Content.Count; i++)
            {
                res.Add(new AllowedEntitity(currentLoop.Content[i], currentLoop));
                if (currentLoop.Content[i].ReqDes == RequirementDesignator.Mandatory)
                    break;
            }

            //if in loop all except first  seg are optional, and max occurs not reached yet - return new loop iteration
            if (currentLoop.ParentLoop != null)
            {
                res.AddRange(GetNextAllowedEntities(currentLoop.ParentLoop));
            }
            return res;
        }
    }
}
