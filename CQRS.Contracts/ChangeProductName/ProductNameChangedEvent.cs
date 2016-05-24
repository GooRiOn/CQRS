using System;

namespace CQRS.Contracts.AddProduct
{
    public class ProductNameChangedEvent : EventBase
    {
        public Guid ProductId { get; set; }
        public string NewName { get; set; }
    }
}
