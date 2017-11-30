namespace EdiEngine.Common.SyntaxNotes
{
    public class ConditionalSyntaxNote : SyntaxNote
    {
        public ConditionalSyntaxNote(string syntaxNote) : base(syntaxNote)
        {
        }

        public override bool IsValid(string[] content)
        {
            int idx = Elements[0];

            if (content.Length <= idx)
                return true;

            if (string.IsNullOrEmpty(content[idx]))
                return true;

            for (int i = 1; i < Elements.Count; ++i)
            {
                idx = Elements[i];
                if (content.Length < idx || string.IsNullOrEmpty(content[idx]))
                    return false;
            }

            return true;
        }
    }
}
