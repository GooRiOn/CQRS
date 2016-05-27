using CQRS.Contracts;
using CQRS.Infrastructure;
using CQRS.Infrastructure.Interfaces.Contracts;
using System.Linq;

namespace CQRS.DataAccess
{
    public class EventPersister : IEventPersister
    {
        Context Context { get; }

        public EventPersister(Context context)
        {
            Context = context;
        }

        public void Persist<TEvent>(TEvent @event) where TEvent : class
        {
            var evType = @event.GetType();

            var genericSetMethod = typeof(Context).GetMethods().First(m=>m.Name == "Set" && m.IsGenericMethod);

            var dbSet = genericSetMethod.MakeGenericMethod(new[] { evType }).Invoke(Context, null);

            dbSet.GetType().GetMethod("Add").Invoke(dbSet, new[] { @event });

            //Context.Set<TEvent>().Add(@event);
            Context.SaveChanges();
        }
    }
}