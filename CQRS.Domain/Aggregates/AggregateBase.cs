using CQRS.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Domain.Aggregates
{
    abstract class AggregateBase<TEventBase>
    {  
        public int AggregateOrdinal { get; set; }

        public abstract void Load(IEventSource<TEventBase> eventSource);
    }
}
