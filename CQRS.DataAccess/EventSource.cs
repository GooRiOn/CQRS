using System.Linq;
using CQRS.Infrastructure;
using CQRS.Infrastructure.Interfaces.Contracts;

namespace CQRS.DataAccess
{
    public class EventSource<TEventBase> : IEventSource<TEventBase> where TEventBase : class, IEvent
    {
        Context Context { get; }

        public EventSource(Context context)
        {
            Context = context;
        }

        public IQueryable<TEventBase> GetEvents() => Context.Events.OfType<TEventBase>();
    }
}