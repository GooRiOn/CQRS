using CQRS.Contracts.Interfaces;
using CQRS.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Domain.Validation
{
    class NullStaticCommandValidator<TCommand> : IStaticCommandValidator<TCommand> where TCommand : class, ICommand
    {
        public IStaticValidationResult ValidateStatic(TCommand command) =>
            new StaticValidationResult { ErrorMessage = null };
    }
}
