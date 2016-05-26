using CQRS.Infrastructure;
using CQRS.Infrastructure.Interfaces.Contracts;

namespace CQRS.DataAccess
{
    public class EventPersister : IEventPersister
    {
        Context Context { get; }

        public EventPersister(Context context)
        {
            Context = context;
        }

        public void Persist<TEvent>(TEvent @event) where TEvent : class, IEvent
        {
            Context.Set<TEvent>().Add(@event);
            Context.SaveChanges();
        }
    }
}