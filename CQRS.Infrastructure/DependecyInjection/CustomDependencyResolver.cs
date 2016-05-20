using Autofac;
using CQRS.Infrastructure.DependecyInjection.Interfaces;

namespace CQRS.Infrastructure.DependecyInjection
{
    public class CustomDependencyResolver : ICustomDependencyResolver
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