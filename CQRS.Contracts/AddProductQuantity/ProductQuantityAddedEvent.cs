using CQRS.Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Contracts.AddProductQuantity
{
    public class ProductQuantityAddedEvent : EventBase
    {
        public Guid ProductId { get; set; }
        public decimal AdditionalQuantity { get; set; }
    }
}
