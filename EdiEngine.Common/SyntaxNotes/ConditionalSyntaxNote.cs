using System.Linq;

namespace EdiEngine.Common.SyntaxNotes
{
    public class ConditionalSyntaxNote : SyntaxNote
    {
        public ConditionalSyntaxNote(string syntaxNote) : base(syntaxNote)
        {
        }

        protected override string Description
            => " If the first element specified in the condition is present, then all others must be present";

        public override bool IsValid(string[] content)
        {
            var res = Elements.Select(idx => GetExtendedList(content)[idx]).ToList();

            if (string.IsNullOrEmpty(res.FirstOrDefault()))
                return true;

            return !res.Any(string.IsNullOrEmpty);
        }
    }
}
