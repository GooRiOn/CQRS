using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Contracts.ChangeProductPrice
{
    public class ChangeProductNameCommand : CommandBase
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; }
    }
}
