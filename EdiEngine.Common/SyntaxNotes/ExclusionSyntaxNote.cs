using System.Linq;

namespace EdiEngine.Common.SyntaxNotes
{
    public class ExclusionSyntaxNote : SyntaxNote
    {
        public ExclusionSyntaxNote(string syntaxNote) : base(syntaxNote)
        {
        }

        protected override string Description => "Not more than one can be present.";

        public override bool IsValid(string[] content)
        {
            var res = Elements.Select(idx => GetExtendedList(content)[idx]).ToList();

            return res.Count(x => !string.IsNullOrEmpty(x)) <= 1;
        }
    }
}
