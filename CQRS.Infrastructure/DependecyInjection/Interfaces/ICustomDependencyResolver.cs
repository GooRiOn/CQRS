namespace CQRS.Infrastructure.DependecyInjection.Interfaces
{
    public interface ICustomDependencyResolver
    {
        TInterface Resolve<TInterface>();
    }
}