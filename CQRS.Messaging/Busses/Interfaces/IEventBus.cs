using System.Threading.Tasks;
using CQRS.Contracts.Interfaces;

namespace CQRS.Messaging.Busses.Interfaces
{
    public interface IEventBus
    {
        void Send<TEvent>(TEvent @event) where TEvent : class, IEvent;

        Task SendAsync<TEvent>(TEvent @event) where TEvent : class, IEvent;
    }
}