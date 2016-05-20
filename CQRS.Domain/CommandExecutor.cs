using CQRS.Domain.Interfaces;
using CQRS.Infrastructure.DependencyInjection.Interfaces;
using CQRS.Contracts.Interfaces;

namespace CQRS.Domain
{
    class CommandExecutor : ICommandExecutor
    {
        ICustomDependencyResolver DependencyResolver { get; }

        public CommandExecutor(ICustomDependencyResolver dependencyResolver)
        {
            DependencyResolver = dependencyResolver;
        }

        public void Execute<TCommand>(TCommand command) where TCommand : class, ICommand =>
            DependencyResolver.Resolve<ICommandHandler<TCommand>>().Handle(command);
    }
}
