using System.Linq;

namespace EdiEngine.Common.SyntaxNotes
{
    public class RequiredSyntaxNote : SyntaxNote
    {
        public RequiredSyntaxNote(string syntaxNote) : base(syntaxNote)
        {
        }

        protected override string Description => "At least one specified in the relational condition must be present";

        public override bool IsValid(string[] content)
        {
            var res = Elements.Select(idx => GetExtendedList(content)[idx]).ToList();

            return res.Any(x => !string.IsNullOrEmpty(x));
        }
    }
}
