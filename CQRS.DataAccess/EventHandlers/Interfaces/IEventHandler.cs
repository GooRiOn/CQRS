using CQRS.Contracts.Events.Interfaces;

namespace CQRS.DataAccess.EventHandlers.Interfaces
{
    public interface IEventHandler<in TEvent> : IEventHandler where TEvent : IEvent
    {
        void Handle(TEvent @event);
    }
}