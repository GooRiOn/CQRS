using CQRS.Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Domain.Interfaces
{
    public interface IStaticCommandValidator<TCommand> where TCommand : class, ICommand
    {
        IStaticValidationResult ValidateStatic(TCommand command);
    }
}
