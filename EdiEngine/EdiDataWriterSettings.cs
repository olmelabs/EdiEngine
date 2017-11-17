using EdiEngine.Common.Definitions;

namespace EdiEngine
{
    public class EdiDataWriterSettings
    {
        public MapSegment IsaDef { get; }
        public MapSegment IeaDef { get; }
        public MapSegment GsDef { get; }
        public MapSegment GeDef { get; }
        public MapSegment StDef { get; }
        public MapSegment SeDef { get; }

        public string IsaSenderQual { get; }
        public string IsaSenderId { get; }
        public string IsaReceiverQual { get; }
        public string IsaReceiverId { get; }
        public string GsSenderId { get; }
        public string GsReceiverId { get; }
        public string IsaEdiVersion { get; }
        public string GsEdiVersion { get; }
        public string IsaUsageIndicator { get; }
        public int IsaFirstControlNumber { get; }
        public int GsFirstControlNumber { get; }

        public string SegmentSeparator { get; }
        public string ElementSeparator { get; }

        public EdiDataWriterSettings(
            MapSegment isaDef,
            MapSegment ieaDef,
            MapSegment gsDef,
            MapSegment geDef,
            MapSegment stDef,
            MapSegment seDef,
            string isaSenderQual,
            string isaSenderId, 
            string isaReceiverQual,
            string isaReceiverId,
            string gsSenderId,
            string gsReceiverId,
            string isaEdiVersion,
            string gsEdiVersion,
            string isaUsageIndicator,
            int isaFirstControlNumber,
            int gsFirstControlNumber,
            string segmentSeparator,
            string elementSeparator
            )
        {
            IsaDef = isaDef;
            IeaDef = ieaDef;
            GsDef = gsDef;
            GeDef = geDef;
            StDef = stDef;
            SeDef = seDef;

            IsaSenderQual = isaSenderQual;
            IsaSenderId = isaSenderId;
            IsaReceiverQual = isaReceiverQual;
            IsaReceiverId = isaReceiverId;
            GsSenderId = gsSenderId;
            GsReceiverId = gsReceiverId;
            IsaEdiVersion = isaEdiVersion;
            GsEdiVersion = gsEdiVersion;
            IsaUsageIndicator = isaUsageIndicator;
            IsaFirstControlNumber = isaFirstControlNumber;
            GsFirstControlNumber = gsFirstControlNumber;
            SegmentSeparator = segmentSeparator;
            ElementSeparator = elementSeparator;
        }
    }
}
