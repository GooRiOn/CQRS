using CQRS.Contracts.Events.Interfaces;

namespace CQRS.Messaging.Busses.Interfaces
{
    public interface IEventBus
    {
        void Send<TEvent>(TEvent @event) where TEvent : IEvent;
    }
}