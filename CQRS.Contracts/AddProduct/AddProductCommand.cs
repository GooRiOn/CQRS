using CQRS.Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Contracts.AddProduct
{
    public class AddProductCommand : CommandBase
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal InititalQuantity { get; set; }
    }
}
