using System.Linq;
using EdiEngine.Common.Definitions;
using EdiEngine.Common.SyntaxNotes;
using EdiEngine.Runtime;

namespace EdiEngine.Validation
{
    public static class SegmentValidator
    {
        public static void ValidateSegment(EdiSegment seg, int rowPos, IValidatedEntity validationScope)
        {
            int i = 0;
            foreach (var dataElement in seg.Content)
            {
                if (dataElement is EdiSimpleDataElement)
                {
                    EdiSimpleDataElement el = (EdiSimpleDataElement) dataElement;
                    ValidateSimpleDataElement(el, seg.Name, rowPos, i + 1, validationScope);
                }
                else if (dataElement is EdiCompositeDataElement)
                {
                    EdiCompositeDataElement c = (EdiCompositeDataElement) dataElement;
                    foreach (EdiSimpleDataElement el in c.Content)
                    {
                        ValidateSimpleDataElement(el, seg.Name, rowPos, i + 1, validationScope);
                    }
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
                        AddError(seg.Name, rowPos, null, $"Syntax note violation '{syntaxNote}'", validationScope);
                    }
                }
            }
        }

        private static void ValidateSimpleDataElement(EdiSimpleDataElement el, string segName, int segPos, int elPos, IValidatedEntity validationScope)
        {
            if (el.Definition == null)
            {
                AddError(segName, segPos, elPos, $"Unexpected element '{el.Val}'", validationScope);
            }
            else if (el.Definition != null && !el.IsValid(el.Definition))
            {
                AddError(segName, segPos, elPos, $"Invalid value '{el.Val}'", validationScope);
            }

        }

        private static void AddError(string segName, int? segPos, int? elPos, string message, IValidatedEntity validationScope)
        {
            ValidationError err = new ValidationError()
            {
                SegmentPos = segPos,
                SegmentName = segName,
                ElementPos = elPos,
                Message = message
            };
            validationScope.ValidationErrors.Add(err);
        }
    }
}
