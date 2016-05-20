using Autofac;
using CQRS.Messaging.Busses;
using CQRS.Messaging.Busses.Interfaces;
using EasyNetQ;

namespace CQRS.Messaging.DependencyInjection
{
    public class Registration : Module
    {
        public static void Register(ContainerBuilder containerBuilder)
        {
            DataAccess.DependencyInjection.Registration.Register(containerBuilder);

            containerBuilder.RegisterType<CommandBus>().As<ICommandBus>().SingleInstance();
        }
    }
}
