namespace CQRS.DataAccess
{
    public class EventStore : IEventStore
    {
        Context Context { get; }
        
        public EventStore(Context context)
        {
            Context = context;
        }
    }
}