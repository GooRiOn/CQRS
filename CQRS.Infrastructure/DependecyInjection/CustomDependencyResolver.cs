using Autofac;

namespace CQRS.Infrastructure.DependecyInjection
{
    public class CustomDependencyResolver
    {
        IContainer Container { get; }

        public CustomDependencyResolver(IContainer container)
        {
            Container = container;
        } 

        public TInterface Resolve<TInterface>()
        {
            return Container.Resolve<TInterface>();
        }
    }
}