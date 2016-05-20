using System.Threading.Tasks;
using CQRS.Messaging.Busses.Interfaces;
using EasyNetQ;
using CQRS.Domain.Interfaces;
using CQRS.Contracts.Interfaces;

namespace CQRS.Messaging.Busses
{
    public class CommandBus : ICommandBus
    {
        IBus Bus { get; }

        ICommandExecutor CommandExecutor { get; }

        public CommandBus(ICommandExecutor commandExecutor)
        {
            CommandExecutor = commandExecutor;

            Bus = RabbitHutch.CreateBus("host:localhost");
            Bus.Subscribe<ICommand>("command_bus_subscription", ProcessBus);
        }

        public void Send<TCommand>(TCommand command) where TCommand : class, ICommand =>
            Bus.Publish(command);

        public async Task SendAsync<TCommand>(TCommand command) where TCommand : class, ICommand =>
            await Bus.PublishAsync(command);

        void ProcessBus(ICommand command)
        {
            var tCommand = command.GetType();

            var tExecutor = CommandExecutor.GetType();

            tExecutor.GetMethod(nameof(ICommandExecutor.Execute)).MakeGenericMethod(tCommand).Invoke(CommandExecutor, new[] { command });
        }        
    }
}