using CQRS.Infrastructure.Interfaces.Contracts;

namespace CQRS.Domain.Interfaces
{
    public interface IStaticCommandValidator<TCommand> where TCommand : class, ICommand
    {
        IStaticValidationResult ValidateStatic(TCommand command);
    }
}
