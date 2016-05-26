using CQRS.Contracts.AddProductQuantity;
using CQRS.Domain.Aggregates;
using CQRS.Domain.Interfaces;

namespace CQRS.Domain.CommandHandlers
{
    class AddProductQuantityCommandHandler : CommandHandlerBase<AddProductQuantityCommand>
    {
        IEventEmitter EventEmitter { get; }

        public AddProductQuantityCommandHandler(IStaticCommandValidator<AddProductQuantityCommand> validator, IEventEmitter eventEmitter)
            :base(commandValidator: validator)
        {
            EventEmitter = eventEmitter;
        }

        protected override ICommandHandlerResult OnHandle(AddProductQuantityCommand command)
        {
            var product = new Product(command.ProductId);
            //product.Load() // z eventsource

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
