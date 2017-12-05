using EdiEngine.Common.Definitions;
using EdiEngine.Runtime;
using System.Collections.Generic;
using System.Linq;
using EdiEngine.Validation;

namespace EdiEngine
{
    public class EdiMapReader : MapReader
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

        public void ProcessRawSegment(string name, string[] content, int rowPos, string compositeSeparator)
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
                _currentLoopInstance.Content.Add(ProcessSegment(ae.Entity, content, rowPos, compositeSeparator, _trans));
            }
            else if (ae?.Entity is MapLoop)
            {
                //find loop definition in map and reset counters
                ae.LoopContext.CurrentPos = ae.LoopContext.Content.IndexOf(ae.Entity);
                _currentLoopDef = (MapLoop)ae.Entity;
                _currentLoopDef.CurrentPos = 0;
                _currentLoopDef.OccuredTimes++;
                _currentLoopDef.Content.ForEach(c => c.OccuredTimes = 0);


                EdiLoop newLoop;
                if (name == "HL")
                {
                    int hl01;
                    int hl02;
                    int.TryParse(content[1], out hl01);
                    bool res02 = int.TryParse(content[2], out hl02);

                    if (hl01 > 1 && res02)
                    {
                        FindParentHlLoopContext(hl02);
                    }
                    else
                    {
                        FindParentLoopContext(ae.LoopContext);
                    }


                    newLoop = new EdiHlLoop(ae.Entity, _currentLoopInstance, hl01, (res02 ? hl02 : (int?)null));
                }
                else
                {
                    FindParentLoopContext(ae.LoopContext);
                    newLoop = new EdiLoop(ae.Entity, _currentLoopInstance);
                }
                
                _currentLoopInstance.Content.Add(newLoop);
                _currentLoopInstance = newLoop;

                ProcessRawSegment(name, content, rowPos, compositeSeparator);
            }
        }

        private void FindParentLoopContext(MapLoop parentLoop)
        {
            while (((MapLoop)_currentLoopInstance.Definition) != parentLoop && _currentLoopInstance.Parent != null)
            {
                _currentLoopInstance = _currentLoopInstance.Parent;
            }
        }

        private void FindParentHlLoopContext(int parentHlLevel)
        {
            while (!(_currentLoopInstance is EdiHlLoop))
            {
                _currentLoopInstance = _currentLoopInstance.Parent;
            }

            if (((EdiHlLoop) _currentLoopInstance).HL01_HierarchicalIdNumber != parentHlLevel)
            {
                _currentLoopInstance = _currentLoopInstance.Parent;
                FindParentHlLoopContext(parentHlLevel);
            }
        }
    }
}
