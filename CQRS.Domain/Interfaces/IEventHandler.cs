using CQRS.Infrastructure.Interfaces.Contracts;

namespace CQRS.Domain.Interfaces
{
    public interface IEventHandler<in TEvent> where TEvent: class
    {
        void Handle(TEvent @event);
    }
}