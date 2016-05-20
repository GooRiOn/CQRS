using CQRS.Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Contracts.AddProduct
{
    public class ProductAddedEvent : EventBase
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal InititalQuantity { get; set; }
        public Guid ProductId { get; set; }
    }
}
