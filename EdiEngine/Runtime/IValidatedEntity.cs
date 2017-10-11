using System.Collections.Generic;

namespace EdiEngine.Runtime
{
    public interface IValidatedEntity
    {
        List<ValidationError> ValidationErrors { get; }
    }
}
