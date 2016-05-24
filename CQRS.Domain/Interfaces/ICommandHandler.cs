using CQRS.Infrastructure.Interfaces.Contracts;

namespace CQRS.Domain.Interfaces
{
    public interface ICommandHandler<TCommand> where TCommand : class, ICommand
    {
        ICommandHandlerResult Handle(TCommand command);
    }
}