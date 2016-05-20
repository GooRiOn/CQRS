using CQRS.Contracts.AddProduct;
using CQRS.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Domain.EventHandlers
{
    class ProductAddedEventHandler : IEventHandler<ProductAddedEvent>
    {
        public ProductAddedEventHandler()
        {
        }

        public void Handle(ProductAddedEvent @event)
        {
            throw new NotImplementedException();
        }
    }
}
