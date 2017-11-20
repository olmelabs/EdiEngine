namespace EdiEngine
{
    public enum AckValidationErrorBehavour
    {
        AcceptAll,
        AcceptButNoteErrors,
        RejectValidationErrors,
    }

    public class AckBuilderSettings
    {
        public AckBuilderSettings(
            AckValidationErrorBehavour validationErrorBehavour,
            bool alwaysGenerateAk2Loop,
            int isaFirstControlNumber,
            int gsFirstControlNumber
            )
        {
            AckValidationErrorBehavour = validationErrorBehavour;
            AlwaysGenerateAk2Loop = alwaysGenerateAk2Loop;
            IsaFirstControlNumber = isaFirstControlNumber;
            GsFirstControlNumber = gsFirstControlNumber;
        }

        public AckValidationErrorBehavour AckValidationErrorBehavour { get; }

        public bool AlwaysGenerateAk2Loop { get; }

        public int IsaFirstControlNumber { get; }
        public int GsFirstControlNumber { get; }
    }
}
