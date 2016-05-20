using CQRS.Contracts.Events.Interfaces;

namespace CQRS.DataAccess.EventHandlers.Interfaces
{
    public interface IEventHandler
    {
        void Handle<TEvent>(TEvent @event) where TEvent : IEvent;
    }
}