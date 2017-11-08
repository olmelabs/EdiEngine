using System;
using System.Collections.Generic;

namespace EdiEngine.Runtime
{
    public class EdiBatch
    {
        public EdiBatch()
        {
            Date = DateTime.Now;
            Interchanges = new List<EdiInterchange>();
        }

        public DateTime Date { get; set; }

        public List<EdiInterchange> Interchanges { get; set; }
    }
}
