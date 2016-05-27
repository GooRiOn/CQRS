using System;

namespace CQRS.Infrastructure.Interfaces.Contracts
{
    public interface ICommand
    {
        Guid AggregateId { get; }
    }
}