using CQRS.Contracts.Events.Interfaces;
using CQRS.DataAccess.EventHandlers.Interfaces;

namespace CQRS.DataAccess.Factories.Interfaces
{
    public interface IEventHandlerFactory
    {
        IEventHandler<TEvent> Get<TEvent>() where TEvent : class, IEvent;
    }
}