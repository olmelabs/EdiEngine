
using System.Collections.Generic;

namespace EdiEngine.Common.SyntaxNotes
{
    public abstract class SyntaxNote
    {
        private readonly string _syntaxNote;
        protected List<int> Elements;

        protected SyntaxNote(string syntaxNote)
        {
            _syntaxNote = syntaxNote;
            Elements = new List<int>();
            Elements.AddRange(GetElements(syntaxNote));
        }

        public override string ToString()
        {
            return _syntaxNote;
        }
        
        public abstract bool IsValid(string[] content);

        public IEnumerable<int> GetElements(string s)
        {
            s = s.Remove(0, 1);
            for (var i = 0; i < s.Length; i += 2)
                yield return int.Parse(s.Substring(i, 2)) - 1;
        }
        
    }
}
