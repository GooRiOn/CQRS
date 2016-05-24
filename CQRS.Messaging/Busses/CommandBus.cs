using System.Threading.Tasks;
using EasyNetQ;
using CQRS.Domain.Interfaces;
using CQRS.Infrastructure.Interfaces.Busses;
using CQRS.Infrastructure.Interfaces.Contracts;

namespace CQRS.Messaging.Busses
{
    public class CommandBus : ICommandBus
    {
        IBus Bus { get; }

        ICommandExecutor CommandExecutor { get; }

        public CommandBus(ICommandExecutor commandExecutor)
        {
            CommandExecutor = commandExecutor;

            Bus = RabbitHutch.CreateBus("host=localhost");
            Bus.Receive<ICommand>("CommandBus", command => ProcessBus(command));
        }

        public void Send<TCommand>(TCommand command) where TCommand : class, ICommand
        {
            Bus.Send("CommandBus", command);
        }

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