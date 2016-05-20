using Autofac;
using CQRS.DependencyInjection;

namespace CQRS.App_Start
{
    public class DependencyInjectionConfig
    {
        public static void Register()
        {
            var b = new ContainerBuilder();

            Registration.Register(b);

            IContainer container = null;

            b.Register(ctx => container);

            container = b.Build();         
        }
    }
}