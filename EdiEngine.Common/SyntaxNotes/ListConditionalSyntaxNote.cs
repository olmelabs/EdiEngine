using System.Linq;

namespace EdiEngine.Common.SyntaxNotes
{
    public class ListConditionalSyntaxNote : SyntaxNote
    {
        public ListConditionalSyntaxNote(string syntaxNote) : base(syntaxNote)
        {
        }

        protected override string Description
            => "If the first element specified is present, then at least one of the remaining elements must be present.";

        public override bool IsValid(string[] content)
        {
            var res = Elements.Select(idx => GetExtendedList(content)[idx]).ToList();

            if (string.IsNullOrEmpty(res.FirstOrDefault()))
                return true;

            return res.Skip(1).Any(x => !string.IsNullOrEmpty(x));
        }
    }
}
