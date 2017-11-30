
using System;

namespace EdiEngine.Common.SyntaxNotes
{
    /// <summary>
    /// P Paired or Multiple
    ///     If any element specified in the relational condition is present, then all must be present
    /// R Required
    ///     At least one specified in the relational condition must be present
    /// E Exclusion
    ///     Not more than one can be present
    /// C Conditional
    ///     If the first element specified in the condition is present, then all others must be present
    /// L List Conditional
    ///     If the first element specified is present, then at least one of the remaining elements must be present
    /// </summary>
    public enum SyntaxNoteType
    {
        Conditional,
        Exclusion,
        ListConditional,
        Paired,
        Required
    }

    public class SyntaxNoteFactory
    {
        public  static SyntaxNote GetSyntaxNote(string syntaxNote)
        {
            switch (syntaxNote[0])
            {
                case 'C':
                    return new ConditionalSyntaxNote(syntaxNote);

                default:
                    throw new NotImplementedException($"Syntax note {syntaxNote} is not implemented");
            }
        }
    }
 }
