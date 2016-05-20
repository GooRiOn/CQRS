using CQRS.Contracts.Commands.Interfaces;

namespace CQRS.DataAccess.CommandHandlers.Interfaces
{
    public interface ICommandHandler<in TCommand> : ICommandHandler where TCommand : ICommand
    {
        void Handle(TCommand command);
    }
}