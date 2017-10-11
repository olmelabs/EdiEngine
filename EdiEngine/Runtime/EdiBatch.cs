using System;
using System.Collections.Generic;

namespace EdiEngine.Runtime
{
    public class EdiBatch
    {
        public EdiBatch()
        {
            Interchanges = new List<EdiInterchange>();
        }

        public string Version { get; set; }
        public DateTime Date { get; set; }
        public string FileName { get; set; }
        public long FileSize { get; set; }
        public List<EdiInterchange> Interchanges { get; set; }
    }
}
