using System;

namespace CQRS.Infrastructure.Interfaces.Contracts
{
    public interface IEvent
    {
        Guid Id { get; }
    }
}