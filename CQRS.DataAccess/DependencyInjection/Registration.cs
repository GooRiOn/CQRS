using Autofac;

namespace CQRS.DataAccess.DependencyInjection
{
    public class Registration : Module
    {
        public static void Register(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<Context>().AsSelf().InstancePerDependency();
        }
    }
}
