using System;

namespace CQRS.Contracts.AddProduct
{
    public class ProductNameChangedEvent : EventBase, IProductEvent
    {
        public string NewName { get; set; }
    }
}
