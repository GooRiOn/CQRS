using System;
using CQRS.Contracts.AddProduct;
using CQRS.Domain.Aggregates;
using CQRS.Domain.Interfaces;

namespace CQRS.Domain.CommandHandlers
{
    class AddProductCommandHandler : CommandHandlerBase<AddProductCommand>
    {
        IEventEmitter EventEmitter { get; }

        public AddProductCommandHandler(IStaticCommandValidator<AddProductCommand> validator, IEventEmitter eventEmitter)
            :base(commandValidator: validator)
        {
            EventEmitter = eventEmitter;
        }

        protected override ICommandHandlerResult OnHandle(AddProductCommand command)
        {
            //TODO: Zapisać 

            EventEmitter.Emit(new ProductAddedEvent
            {
                InititalQuantity = command.InititalQuantity,
                Name = command.Name,
                Price = command.Price,
                ProductId = command.Id
            });
            return Ok();
        }
    }
}
