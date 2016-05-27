using System;

namespace CQRS.DataAccess.Entities
{
    public class EventsEntity 
    {
         public Guid AggregateId { get; set; }

         public int Version { get; set; }

         public string EventState { get; set; }
    }
}