using CQRS.Contracts;
using CQRS.Contracts.AddProductQuantity;
using CQRS.Domain.Aggregates;
using CQRS.Domain.Interfaces;
using CQRS.Infrastructure;

namespace CQRS.Domain.CommandHandlers
{
    class AddProductQuantityCommandHandler : CommandHandlerBase<AddProductQuantityCommand>
    {
        IEventStore EventStore { get; }

        IEventEmitter EventEmitter { get; }

        public AddProductQuantityCommandHandler(IStaticCommandValidator<AddProductQuantityCommand> validator, 
            IEventEmitter eventEmitter,
            IEventStore eventStore)
            :base(commandValidator: validator)
        {
            EventEmitter = eventEmitter;
            EventStore = eventStore;
        }

        protected override ICommandHandlerResult OnHandle(AddProductQuantityCommand command)
        {
            var product = new Product(command.ProductId);
            product.Load(EventStore.GetSource<IProductEvent>()); // z eventsource

            // TODO: siakieś metody na produkcie jak potrzebne

            EventEmitter.Emit(new ProductQuantityAddedEvent
            {
                AggregateId = command.ProductId,
                AggregateOrdinal = product.AggregateOrdinal + 1,
                AdditionalQuantity = command.AdditionalQuantity
            });

            return Ok();
        }
    }
}
