using System.Threading.Tasks;
using CQRS.Contracts.Commands.Interfaces;
using CQRS.DataAccess.Factories.Interfaces;
using CQRS.Messaging.Busses.Interfaces;
using EasyNetQ;

namespace CQRS.Messaging.Busses
{
    public class CommandBus : ICommandBus
    {
        IBus Bus { get; }
        ICommandHandlerFactory CommandHandlerFactory { get; }

        public CommandBus(ICommandHandlerFactory commandHandlerFactory)
        {
            CommandHandlerFactory = commandHandlerFactory;

            Bus = RabbitHutch.CreateBus("host:localhost");
            Bus.Subscribe<ICommand>("command_bus_subscription", ProccessBus);
        }

        public void Send<TCommand>(TCommand command) where TCommand : class, ICommand
        {
            Bus.Publish(command);
        }

        public async Task SendAsync<TCommand>(TCommand command) where TCommand : class, ICommand
        {
            await Bus.PublishAsync(command);
        }

        private void ProccessBus<TCommand>(TCommand command) where TCommand : class, ICommand
        {
            var commandHandler = CommandHandlerFactory.Get<TCommand>();
            commandHandler.Handle(command);
        }
    }
}