using System;
using CQRS.Infrastructure.Interfaces.Contracts;

namespace CQRS.Contracts
{
    public class EventBase : IEvent
    {
        public Guid Id { get; } = Guid.NewGuid();

        public Guid SourceId { get; set; }
    }
}
