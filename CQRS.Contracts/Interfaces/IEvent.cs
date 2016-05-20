using System;

namespace CQRS.Contracts.Interfaces
{
    public interface IEvent
    {
        Guid Id { get; }
        Guid SourceId { get; }
    }
}