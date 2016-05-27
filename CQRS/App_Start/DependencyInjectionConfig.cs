using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.WebApi;
using CQRS.Controllers;
using CQRS.Infrastructure.DependencyInjection;
using CQRS.Infrastructure.DependencyInjection.Interfaces;
using Owin;
using Registration = CQRS.DependencyInjection.Registration;

namespace CQRS.App_Start
{
    public class DependencyInjectionConfig
    {
        public static void Register(IAppBuilder appBuilder)
        {
            var containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            var config = GlobalConfiguration.Configuration;

            containerBuilder.RegisterWebApiFilterProvider(config);

            containerBuilder.Register(c => HttpContext.Current).As<HttpContext>().InstancePerRequest();
            containerBuilder.Register(c => HttpContext.Current.Request).As<HttpRequest>().InstancePerRequest();

            Registration.Register(containerBuilder);

            IContainer container = null;
            containerBuilder.Register(c => container);
            container = containerBuilder.Build();

            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            appBuilder.UseAutofacMiddleware(container);
            appBuilder.UseAutofacWebApi(config);
        }
    }
}