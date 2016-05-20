using Autofac;
using CQRS.DependencyInjection;
using CQRS.Infrastructure.DependecyInjection;
using CQRS.Infrastructure.DependecyInjection.Interfaces;

namespace CQRS.App_Start
{
    public class DependencyInjectionConfig
    {
        public static void Register()
        {
            var conatinerBuilder = new ContainerBuilder();
            Registration.Register(conatinerBuilder);

            var container = conatinerBuilder.Build();

            var customDependencyResolverConatinerBuilder = new ContainerBuilder();

            customDependencyResolverConatinerBuilder.RegisterType<CustomDependencyResolver>()
                .As<ICustomDependencyResolver>();

            customDependencyResolverConatinerBuilder.Update(container);
        }
    }
}