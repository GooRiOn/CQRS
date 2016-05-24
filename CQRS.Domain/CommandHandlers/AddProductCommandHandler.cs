using CQRS.Contracts.AddProduct;
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
    class AddProductCommandHandler : CommandHandlerBase<AddProductCommand>
    {
        public AddProductCommandHandler(IStaticCommandValidator<AddProductCommand> validator)
            :base(commandValidator: validator)
        {
        }

        protected override ICommandHandlerResult OnHandle(AddProductCommand command)
        {
            var product = new Product(Guid.NewGuid());
                          
            //TODO: Zapisać i wygenerować zdarzenie ProductAdded...
            return Ok();
        }
    }
}
