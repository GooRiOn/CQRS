using System.Threading.Tasks;
using CQRS.Infrastructure.Interfaces.Contracts;

namespace CQRS.Infrastructure.Interfaces.Busses
{
    public interface IEventBus
    {
        void Send<TEvent>(TEvent @event) where TEvent : class;

        Task SendAsync<TEvent>(TEvent @event) where TEvent : class;
    }
}