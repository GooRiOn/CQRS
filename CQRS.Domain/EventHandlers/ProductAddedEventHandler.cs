using CQRS.Contracts.AddProduct;
using CQRS.Domain.Interfaces;
using System;

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
