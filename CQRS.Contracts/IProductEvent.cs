using CQRS.Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Contracts
{
    public interface IProductEvent : IEvent
    {
        Guid ProductId { get; }
    }
}
