using CQRS.Contracts.Events.Interfaces;
using CQRS.DataAccess.EventHandlers.Interfaces;
using CQRS.DataAccess.Factories.Interfaces;
using CQRS.Infrastructure.DependecyInjection.Interfaces;

namespace CQRS.DataAccess.Factories
{
    public class EventHandlerFactory : IEventHandlerFactory
    {
        ICustomDependencyResolver CustomDependencyResolver { get; }

        public EventHandlerFactory(ICustomDependencyResolver customDependencyResolver)
        {
            CustomDependencyResolver = customDependencyResolver;
        }

        public IEventHandler<TEvent> Get<TEvent>() where TEvent : class, IEvent
        {
            return CustomDependencyResolver.Resolve<IEventHandler<TEvent>>();
        }
    }
}
