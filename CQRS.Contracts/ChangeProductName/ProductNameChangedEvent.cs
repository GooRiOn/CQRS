using CQRS.Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Contracts.AddProduct
{
    public class ProductNameChangedEvent : EventBase
    {
        public Guid ProductId { get; set; }
        public string NewName { get; set; }
    }
}
