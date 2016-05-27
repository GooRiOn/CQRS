using CQRS.Infrastructure.Interfaces.Contracts;

namespace CQRS.Domain
{
    public interface IEventEmitter
    {
        void Emit<TEvent>(TEvent @event) where TEvent : class;
    }
}