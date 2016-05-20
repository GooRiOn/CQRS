using Autofac;
using CQRS.DataAccess.Factories;
using CQRS.DataAccess.Factories.Interfaces;

namespace CQRS.DataAccess.DependencyInjection
{
    public class Registration : Module
    {
        public static void Register(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<CommandHandlerFactory>().As<ICommandHandlerFactory>();
            containerBuilder.RegisterType<EventHandlerFactory>().As<IEventHandlerFactory>();
            containerBuilder.RegisterType<Context>().AsSelf().InstancePerDependency();
        }
    }
}
