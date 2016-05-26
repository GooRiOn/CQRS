using CQRS.Infrastructure.Interfaces.Contracts;

namespace CQRS.Domain.Interfaces
{
    public interface IEventHandler<in TEvent> where TEvent : IEvent
    {
        void Handle(TEvent @event);
    }
}