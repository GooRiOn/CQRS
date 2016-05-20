using CQRS.Contracts.Commands.Interfaces;
using CQRS.Messaging.Busses.Interfaces;

namespace CQRS.Messaging.Busses
{
    public class CommandBus : ICommandBus
    {
        public void Send<TCommand>(TCommand command) where TCommand : ICommand
        {
            throw new System.NotImplementedException();
        }
    }
}