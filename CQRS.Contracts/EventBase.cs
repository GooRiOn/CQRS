using CQRS.Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Contracts
{
    public class EventBase : IEvent
    {
        public Guid Id { get; } = Guid.NewGuid();

        public Guid SourceId { get; set; }
    }
}
