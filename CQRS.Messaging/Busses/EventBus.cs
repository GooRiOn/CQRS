using System.Threading.Tasks;
using CQRS.Contracts.Events.Interfaces;
using CQRS.DataAccess.Factories.Interfaces;
using EasyNetQ;
using IEventBus = CQRS.Messaging.Busses.Interfaces.IEventBus;

namespace CQRS.Messaging.Busses
{
    public class EventBus : IEventBus
    {
        //TODO: Inject IBus, move static string to config

        IBus Bus { get; }
        IEventHandlerFactory EventHandlerFactory { get; }

        public EventBus(IEventHandlerFactory eventHandlerFactory)
        {
            EventHandlerFactory = eventHandlerFactory;

            Bus = RabbitHutch.CreateBus("host:localhost");
            Bus.Subscribe<IEvent>("event_bus_subscription", ProcessBus);
        }

        public void Send<TEvent>(TEvent @event) where TEvent : class, IEvent
        {
            Bus.Publish(@event);
        }

        public async Task SendAsync<TEvent>(TEvent @event) where TEvent : class, IEvent
        {
            await Bus.PublishAsync(@event);
        }

        private void ProcessBus<TEvent>(TEvent @event) where TEvent : class, IEvent
        {
            var eventHandler = EventHandlerFactory.Get<TEvent>();
            eventHandler.Handle(@event);
        }
    }
}
