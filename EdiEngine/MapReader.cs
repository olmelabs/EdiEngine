using System;
using System.Collections.Generic;
using System.Linq;
using EdiEngine.Common.Definitions;
using EdiEngine.Common.Enums;
using EdiEngine.Runtime;
using EdiEngine.Validation;

namespace EdiEngine
{
    public abstract class MapReader
    {
        protected List<AllowedEntitity> GetNextAllowedEntities(MapLoop currentLoop)
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

        public static EdiSegment ProcessSegment(MapBaseEntity definition, string[] content, int rowPos, string compositeSeparator, IValidatedEntity validationScope)
        {
            MapSegment segDef = (MapSegment)definition;
            EdiSegment seg = new EdiSegment(segDef);

            int i = 0;
            foreach (string val in content.Skip(1))
            {
                MapSimpleDataElement elDef = null;
                MapCompositeDataElement cDef = null;
                if (i < segDef.Content.Count)
                {
                    if (segDef.Content[i] is MapSimpleDataElement)
                        elDef = (MapSimpleDataElement) segDef.Content[i];
                    else if (segDef.Content[i] is MapCompositeDataElement)
                        cDef = (MapCompositeDataElement)segDef.Content[i];
                }

                //if cDef is null - create simple element. Even if elDef is null 
                // validation will add error of unknown element later on
                if (cDef == null)
                {
                    EdiSimpleDataElement el = new EdiSimpleDataElement(elDef, val);
                    seg.Content.Add(el);
                }
                else
                {
                    EdiCompositeDataElement composite = new EdiCompositeDataElement(cDef);
                    string[] compositeContent = val.Split(new[] {compositeSeparator}, StringSplitOptions.None);
                    ProcessComposite(composite, compositeContent);
                    seg.Content.Add(composite);
                }

                i++;
            }

            SegmentValidator.ValidateSegment(seg, rowPos, validationScope);
            return seg;
        }

        private static void ProcessComposite(EdiCompositeDataElement composite, string [] content)
        {
            int i = 0;
            foreach (string val in content)
            {
                MapSimpleDataElement elDef = null;
                if (i < composite.Definition.Content.Count)
                    elDef = composite.Definition.Content[i];

                EdiSimpleDataElement el = new EdiSimpleDataElement(elDef, val);
                composite.Content.Add(el);

                i++;
            }
        }
    }
}
