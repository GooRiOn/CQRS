using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Contracts.ChangeProductPrice
{
    public class ChangeProductPriceCommand : CommandBase
    {
        public Guid ProductId { get; set; }
        public decimal NewPrice { get; set; }
    }
}
