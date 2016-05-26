using Autofac;
using CQRS.Infrastructure;

namespace CQRS.DataAccess.DependencyInjection
{
    public class Registration : Module
    {
        public static void Register(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<Context>().AsSelf().InstancePerDependency();

            containerBuilder.RegisterType<EventPersister>().As<IEventPersister>();

            containerBuilder.RegisterGeneric(typeof (EventSource<>)).As(typeof (IEventSource<>));

            containerBuilder.RegisterType<EventStore>().As<IEventStore>();
        }
    }
}
