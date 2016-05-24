using System;

namespace CQRS.Contracts.Interfaces
{
    public interface IEvent
    {
        Guid Id { get; }
        Guid AggregateId { get; }
        int AggregateOrdinal { get; }
    }
}