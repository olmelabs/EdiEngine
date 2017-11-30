using System.Collections.Generic;
using System.Linq;
using EdiEngine.Common.Definitions;
using EdiEngine.Common.Enums;
using EdiEngine.Common.SyntaxNotes;
using EdiEngine.Runtime;

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

            if (segDef.SyntaxNotes != null && segDef.SyntaxNotes.Count > 0)
            {
                foreach (var sn in segDef.SyntaxNotes)
                {
                    var syntaxNote = SyntaxNoteFactory.GetSyntaxNote(sn);
                    if (!syntaxNote.IsValid(content.Skip(1).ToArray()))
                    {
                        ValidationError err = new ValidationError()
                        {
                            SegmentPos = rowPos,
                            SegmentName = content[0],
                            Message = $"Syntax note violation '{syntaxNote}'"
                        };
                        validationScope.ValidationErrors.Add(err);
                    }

                }
            }

            return seg;
        }
    }
}
