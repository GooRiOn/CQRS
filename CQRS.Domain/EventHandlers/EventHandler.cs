using CQRS.Domain.Interfaces;
using CQRS.Infrastructure;
using CQRS.Infrastructure.Interfaces.Contracts;

namespace CQRS.Domain.EventHandlers
{
    public class EventHandler<TEvent> : IEventHandler<TEvent> where TEvent : class, IEvent
    {
        IEventPersister EventPersister { get; }

        public EventHandler(IEventPersister eventPersister)
        {
            EventPersister = eventPersister;
        }

        public void Handle(TEvent @event)
        {
            EventPersister.Persist(@event);
        }
    }
}