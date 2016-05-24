using CQRS.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRS.Infrastructure;
using CQRS.Contracts.AddProduct;
using CQRS.Contracts.AddProductQuantity;

namespace CQRS.Domain.Aggregates
{
    class Product : AggregateBase<IProductEvent>
    {  
        public Guid ProductId { get; }

        public decimal Quantity { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }

        public Product(Guid productId)
        {
            ProductId = productId;
        }

        public override void Load(IEventSource<IProductEvent> eventSource)
        {
            foreach (var ev in eventSource.GetEvents().OrderBy(e => e.AggregateOrdinal).Where(p=>p.ProductId == ProductId))
            {
                var productAdded = ev as ProductAddedEvent;
                if(productAdded != null)
                {
                    Name = productAdded.Name;
                    Quantity = productAdded.InititalQuantity;
                    Price = productAdded.Price;
                }

                var productPriceChanged = ev as ProductPriceChangedEvent;
                if (productPriceChanged != null)
                    Price = productPriceChanged.NewPrice;

                var ProductNameChanged = ev as ProductNameChangedEvent;
                if (ProductNameChanged != null)
                    Name = ProductNameChanged.NewName;

                var productQuantityAdded = ev as ProductQuantityAddedEvent;
                if (productQuantityAdded != null)
                    Quantity += productQuantityAdded.AdditionalQuantity;
            }                     
        }
    }
}
