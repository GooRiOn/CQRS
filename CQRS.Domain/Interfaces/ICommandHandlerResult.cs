using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Domain.Interfaces
{
    public interface ICommandHandlerResult
    {
        bool IsOk { get; }
        bool HasError { get; }
        string ErrorMessage { get; } // TODO: Extend into ErrorMessages
    }
}
