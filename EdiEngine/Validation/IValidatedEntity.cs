using System.Collections.Generic;
using EdiEngine.Runtime;

namespace EdiEngine.Validation
{
    public interface IValidatedEntity
    {
        List<ValidationError> ValidationErrors { get; }
    }
}
