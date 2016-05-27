using CQRS.Infrastructure.Interfaces.Contracts;
using System;

namespace CQRS.Contracts.AddProduct
{
    public class ProductAddedEvent : EventBase//, IEvent
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal InititalQuantity { get; set; }
    }
}
