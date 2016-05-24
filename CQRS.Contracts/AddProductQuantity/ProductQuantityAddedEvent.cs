using System;

namespace CQRS.Contracts.AddProductQuantity
{
    public class ProductQuantityAddedEvent : EventBase, IProductEvent
    {
        public decimal AdditionalQuantity { get; set; }
    }
}
