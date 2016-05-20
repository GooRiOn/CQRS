using Autofac;
using CQRS.Infrastructure.DependencyInjection;
using CQRS.Infrastructure.DependencyInjection.Interfaces;

namespace CQRS.Infrastructure.DependencyInjection
{
    public class Registration : Module
    {
        public static void Register(ContainerBuilder containerBuilder)
        {
            containerBuilder
                .RegisterType<CustomDependencyResolver>()
                .As<ICustomDependencyResolver>();
        }
    }
}