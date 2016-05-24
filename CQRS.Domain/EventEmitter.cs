using CQRS.Infrastructure.Interfaces.Busses;
using CQRS.Infrastructure.Interfaces.Contracts;

namespace CQRS.Domain
{
    public class EventEmitter : IEventEmitter
    {
        IEventBus EventBus { get; }

        public EventEmitter(IEventBus eventBus)
        {
            EventBus = eventBus;
        }

        public void Emit<TEvent>(TEvent @event) where TEvent : class, IEvent =>
            EventBus.Send(@event);
    }
}