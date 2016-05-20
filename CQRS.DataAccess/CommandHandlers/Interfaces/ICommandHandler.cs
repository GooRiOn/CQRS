using CQRS.Contracts.Commands.Interfaces;

namespace CQRS.DataAccess.CommandHandlers.Interfaces
{
    public interface ICommandHandler
    {
        void Handle<TCommand>(TCommand command) where TCommand : ICommand;
    }
}