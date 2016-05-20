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

            conatinerBuilder.RegisterType<CustomDependencyResolver>()
                .As<ICustomDependencyResolver>();

            var container = conatinerBuilder.Build();

            //var containerBuilder = new ContainerBuilder();

            //containerBuilder
               

            //containerBuilder.Update(container);
        }
    }
}