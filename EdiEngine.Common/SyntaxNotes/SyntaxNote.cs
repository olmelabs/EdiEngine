
using System.Collections.Generic;
using System.Linq;

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

        protected abstract string Description { get; }

        public override string ToString()
        {
            return $"{_syntaxNote} - {Description}";
        }
        
        public abstract bool IsValid(string[] content);

        private IEnumerable<int> GetElements(string s)
        {
            s = s.Remove(0, 1);
            for (var i = 0; i < s.Length; i += 2)
                yield return int.Parse(s.Substring(i, 2)) - 1;
        }

        /// <summary>
        /// add empty elements to the end of list so we do not have index ut of range
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        protected List<string> GetExtendedList(string[] content)
        {
            int maxPos = Elements.Max();
            if (maxPos <  content.Length)
                return new List<string>(content);

            List<string> contentCopy = new List<string>(maxPos);
            contentCopy.AddRange(content);
            contentCopy.AddRange(Enumerable.Repeat("", maxPos - content.Length + 1));

            return contentCopy;
        }
    }
}
