using CQRS.Contracts.AddProduct;
using CQRS.Contracts.AddProductQuantity;
using CQRS.Contracts.ChangeProductPrice;
using CQRS.Domain.Aggregates;
using CQRS.Domain.Interfaces;
using CQRS.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Domain.CommandHandlers
{
    class AddProductQuantityCommandHandler : CommandHandlerBase<AddProductQuantityCommand>
    {
        public AddProductQuantityCommandHandler(IStaticCommandValidator<AddProductQuantityCommand> validator)
            :base(commandValidator: validator)
        {
        }

        protected override ICommandHandlerResult OnHandle(AddProductQuantityCommand command)
        {
            var product = new Product(command.ProductId);
            //product.Load() // z eventsource

            // TODO: siakieś metody na produkcie

            //TODO: wygenerować zdarzenie ProductQuantityAdded...
            return Ok();
        }
    }
}
