using CQRS.Infrastructure;
using CQRS.Infrastructure.DependencyInjection.Interfaces;
using CQRS.Infrastructure.Interfaces.Contracts;

namespace CQRS.DataAccess
{
    public class EventStore : IEventStore
    {
        ICustomDependencyResolver CustomDepenencyResolver { get; }

        public EventStore(ICustomDependencyResolver customDepenencyResolver)
        {
            CustomDepenencyResolver = customDepenencyResolver;
        }

        public IEventSource<TEventBase> GetSource<TEventBase>() where TEventBase : class, IEvent
        {
            return CustomDepenencyResolver.Resolve<IEventSource<TEventBase>>();
        }
    }
}