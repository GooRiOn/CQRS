using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Contracts.AddProduct
{
    public class ProductPriceChangedEvent : EventBase, IProductEvent
    {
        public decimal NewPrice { get; set; }
    }
}
