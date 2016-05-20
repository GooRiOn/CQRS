using CQRS.Contracts.Interfaces;

namespace CQRS.Domain.Interfaces
{
    public interface IEventHandler<TEvent> where TEvent : IEvent
    {
        void Handle(TEvent @event);
    }
}