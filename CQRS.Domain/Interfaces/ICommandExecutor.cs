using CQRS.Infrastructure.Interfaces.Contracts;

namespace CQRS.Domain.Interfaces
{
    public interface ICommandExecutor
    {
        void Execute<TCommand>(TCommand command) where TCommand : class, ICommand;
    }
}
