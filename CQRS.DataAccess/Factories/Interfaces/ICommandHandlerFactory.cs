using CQRS.Contracts.Commands.Interfaces;
using CQRS.DataAccess.CommandHandlers.Interfaces;

namespace CQRS.DataAccess.Factories.Interfaces
{
    public interface ICommandHandlerFactory
    {
        ICommandHandler<TCommand> Get<TCommand>() where TCommand : class, ICommand;
    }
}