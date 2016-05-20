using CQRS.Contracts.Events.Interfaces;

namespace CQRS.DataAccess.Factories.Interfaces
{
    public interface IEventHandlerFactory
    {
        TEventHandler Get<TEventHandler, TEvent>(TEvent @event) where TEvent : class, IEvent;
    }
}