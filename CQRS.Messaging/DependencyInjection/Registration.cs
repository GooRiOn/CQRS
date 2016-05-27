using Autofac;
using CQRS.Infrastructure.Interfaces.Busses;
using CQRS.Messaging.Busses;

namespace CQRS.Messaging.DependencyInjection
{
    public class Registration : Module
    {
        public static void Register(ContainerBuilder containerBuilder)
        {
            DataAccess.DependencyInjection.Registration.Register(containerBuilder);
            Domain.DependencyInjection.Registration.Register(containerBuilder);

            containerBuilder.RegisterType<CommandBus>().As<ICommandBus>().SingleInstance();

            containerBuilder.RegisterType<EventBus>().As<IEventBus>().SingleInstance();
        }
    }
}
