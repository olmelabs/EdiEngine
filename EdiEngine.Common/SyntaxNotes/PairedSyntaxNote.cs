using System.Linq;

namespace EdiEngine.Common.SyntaxNotes
{
    public class PairedSyntaxNote : SyntaxNote
    {
        public PairedSyntaxNote(string syntaxNote) : base(syntaxNote)
        {
        }

        protected override string Description
            => "If any element specified in the relational condition is present, then all must be present.";

        public override bool IsValid(string[] content)
        {
            var res = Elements.Select(idx => GetExtendedList(content)[idx]).ToList();

            return res.Any(string.IsNullOrEmpty) ^ res.Any(x => !string.IsNullOrEmpty(x));
        }
    }
}
