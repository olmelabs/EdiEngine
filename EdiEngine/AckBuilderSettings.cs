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
            bool alwaysGenerateAk2Loop)
        {
            AckValidationErrorBehavour = validationErrorBehavour;
            AlwaysGenerateAk2Loop = alwaysGenerateAk2Loop;
        }

        public AckValidationErrorBehavour AckValidationErrorBehavour { get; }

        public bool AlwaysGenerateAk2Loop { get; }
    }
}
