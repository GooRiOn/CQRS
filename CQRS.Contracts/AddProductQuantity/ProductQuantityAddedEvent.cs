using System;

namespace CQRS.Contracts.AddProductQuantity
{
    public class ProductQuantityAddedEvent : EventBase
    {
        public Guid ProductId { get; set; }
        public decimal AdditionalQuantity { get; set; }
    }
}
