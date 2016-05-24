using CQRS.Domain.Interfaces;
using CQRS.Infrastructure.Interfaces.Contracts;

namespace CQRS.Domain.Validation
{
    class NullStaticCommandValidator<TCommand> : IStaticCommandValidator<TCommand> where TCommand : class, ICommand
    {
        public IStaticValidationResult ValidateStatic(TCommand command) =>
            new StaticValidationResult { ErrorMessage = null };
    }
}
