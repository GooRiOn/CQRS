using Autofac;
using CQRS.DataAccess.Factories;
using CQRS.DataAccess.Factories.Interfaces;

namespace CQRS.DataAccess.DependencyInjection
{
    public class Registration : Module
    {
        public static void Register(ContainerBuilder conatinerBuilder)
        {
            conatinerBuilder.RegisterType<CommandHandlerFactory>().As < ICommandHandlerFactory();
        }
    }
}
