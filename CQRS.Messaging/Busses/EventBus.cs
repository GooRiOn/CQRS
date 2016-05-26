using System.Threading.Tasks;
using CQRS.Domain.Interfaces;
using CQRS.Infrastructure.DependencyInjection.Interfaces;
using EasyNetQ;
using IEventBus = CQRS.Infrastructure.Interfaces.Busses.IEventBus;
using CQRS.Infrastructure.Interfaces.Contracts;

namespace CQRS.Messaging.Busses
{
    public class EventBus : IEventBus
    {
        IBus Bus { get; }
        ICustomDependencyResolver CustomDependencyResolver { get; }

        public EventBus(ICustomDependencyResolver customDependencyResolver)
        {
            CustomDependencyResolver = customDependencyResolver;

            Bus = RabbitHutch.CreateBus("host=localhost");
            Bus.Receive<IEvent>("EventBus", @event => ProcessBus(@event));
        }

        public void Send<TEvent>(TEvent @event) where TEvent : class, IEvent =>
            Bus.Send("EventBus",@event);
        

        public async Task SendAsync<TEvent>(TEvent @event) where TEvent : class, IEvent =>
            await Bus.SendAsync("EventBus", @event);
        

        private void ProcessBus<TEvent>(TEvent @event) where TEvent : class, IEvent
        {
            var eventHandler = CustomDependencyResolver.Resolve<IEventHandler<TEvent>>();
            eventHandler.Handle(@event);
        }
    }
}
