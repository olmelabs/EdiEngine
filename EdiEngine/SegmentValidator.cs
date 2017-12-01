using System.Linq;
using EdiEngine.Common.Definitions;
using EdiEngine.Common.SyntaxNotes;
using EdiEngine.Runtime;

namespace EdiEngine
{
    public static class SegmentValidator
    {
        public static void ValidateSegment(EdiSegment seg, int rowPos, IValidatedEntity validationScope)
        {
            int i = 0;
            foreach (var dataElement in seg.Content)
            {
                if (dataElement.Definition == null)
                {
                    ValidationError err = new ValidationError()
                    {
                        SegmentPos = rowPos,
                        SegmentName = seg.Name,
                        ElementPos = i + 1,
                        Message = $"Unexpected element '{dataElement.Val}'"
                    };
                    validationScope.ValidationErrors.Add(err);
                }

                if (dataElement.Definition != null && !dataElement.IsValid(dataElement.Definition))
                {
                    ValidationError err = new ValidationError()
                    {
                        SegmentPos = rowPos,
                        SegmentName = seg.Name,
                        ElementPos = i + 1,
                        Message = $"Invalid value '{dataElement.Val}'"
                    };
                    validationScope.ValidationErrors.Add(err);
                }
                i++;
            }

            var syntaxNotes = ((MapSegment) seg.Definition).SyntaxNotes;
            if (syntaxNotes != null && syntaxNotes.Count > 0)
            {
                foreach (var sn in syntaxNotes)
                {
                    var syntaxNote = SyntaxNoteFactory.GetSyntaxNote(sn);
                    if (!syntaxNote.IsValid(seg.Content.Select(e => e.Val).ToArray()))
                    {
                        ValidationError err = new ValidationError()
                        {
                            SegmentPos = rowPos,
                            SegmentName =  seg.Name,
                            Message = $"Syntax note violation '{syntaxNote}'"
                        };
                        validationScope.ValidationErrors.Add(err);
                    }

                }
            }

        }
    }
}
