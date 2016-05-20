using CQRS.Contracts.Interfaces;

namespace CQRS.Domain.Interfaces
{
    public interface ICommandHandler<TCommand> where TCommand : class, ICommand
    {
        ICommandHandlerResult Handle(TCommand command);
    }
}