using System;
using CQRS.Infrastructure.Interfaces.Contracts;
using System.ComponentModel.DataAnnotations;

namespace CQRS.Contracts
{
    public class EventBase// : IEvent
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid AggregateId { get; set; }

        public int AggregateOrdinal { get; set; }
    }
}
