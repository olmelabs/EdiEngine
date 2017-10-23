using EdiEngine.Common.Definitions;
namespace EdiEngine.Runtime
{
    public class ST : EdiSegment
    {
        public ST(string[] elements) : base(null)
        {
            foreach (string el in elements)
            {
                Content.Add(new EdiDataElement(null, el));
            }
        }

        public ST(MapBaseEntity definition,
        string ST01_TransactionId,
        int ST02_ControlNumber
        ) : base(definition)
        {
            string tcn = ST02_ControlNumber.ToString();
            if (tcn.Length < 4)
            {
                tcn = tcn.PadLeft(4, '0');
            }

            Content.AddRange(new[] {
                new EdiDataElement(null, ST01_TransactionId),
                new EdiDataElement(null, tcn),
            });
        }
    }
}
