using System.Linq;
using CQRS.Infrastructure.Interfaces.Contracts;

namespace CQRS.Infrastructure
{
    public interface IEventSource<out TEventBase>
    {
        IQueryable<TEventBase> GetEvents();
    }
}
