using CQRS.Domain.Interfaces;
using CQRS.Infrastructure.DependencyInjection.Interfaces;
using CQRS.Infrastructure.Interfaces.Contracts;

namespace CQRS.Domain
{
    public class EventExecutor : IEventExecutor
    {
        ICustomDependencyResolver CustomDependencyResolver { get; }

        public EventExecutor(ICustomDependencyResolver customDependencyResolver)
        {
            CustomDependencyResolver = customDependencyResolver;
        }

        public void Execute<TEvent>(TEvent @event) where TEvent : class, IEvent
        {
            CustomDependencyResolver.Resolve<IEventHandler<TEvent>>().Handle(@event);
        }
    }
}