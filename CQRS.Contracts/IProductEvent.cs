using CQRS.Infrastructure.Interfaces.Contracts;
using System;

namespace CQRS.Contracts
{
    public interface IProductEvent : IEvent
    {
        Guid ProductId { get; }
    }
}
