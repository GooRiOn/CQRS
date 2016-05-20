using CQRS.Contracts.Commands.Interfaces;
using CQRS.DataAccess.CommandHandlers.Interfaces;
using CQRS.DataAccess.Factories.Interfaces;
using CQRS.Infrastructure.DependecyInjection.Interfaces;

namespace CQRS.DataAccess.Factories
{
    public class CommandHandlerFactory : ICommandHandlerFactory
    {
        ICustomDependencyResolver CustomDependencyResolver { get; }

        public CommandHandlerFactory(ICustomDependencyResolver customDependencyResolver)
        {
            CustomDependencyResolver = customDependencyResolver;
        }

        public ICommandHandler<TCommand> Get<TCommand>(TCommand command) where TCommand : class, ICommand
        {
            return CustomDependencyResolver.Resolve<ICommandHandler<TCommand>>();
        }
    }
}
