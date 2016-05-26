using CQRS.Infrastructure.Interfaces.Contracts;

namespace CQRS.Infrastructure
{
    public interface IEventStore
    {
        IEventSource<TEventBase> GetSource<TEventBase>() where TEventBase : class, IEvent;
    }
}
