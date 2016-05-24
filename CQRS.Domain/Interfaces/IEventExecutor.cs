using CQRS.Infrastructure.Interfaces.Contracts;

namespace CQRS.Domain.Interfaces
{
    public interface IEventExecutor
    {
        void Execute<TEvent>(TEvent @event) where TEvent : class, IEvent;
    }
}