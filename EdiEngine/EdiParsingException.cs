using System;

namespace EdiEngine
{
    public class EdiParsingException : Exception
    {
        public EdiParsingException(string message) : base(message) { }
    }
}
