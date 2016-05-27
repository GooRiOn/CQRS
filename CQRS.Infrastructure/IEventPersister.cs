using CQRS.Infrastructure.Interfaces.Contracts;

namespace CQRS.Infrastructure
{
    public interface IEventPersister
    {
        void Persist<TEvent>(TEvent @event) where TEvent : class;
    }
}