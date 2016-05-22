using System.Reflection;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using CQRS.App_Start;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(CQRS.Startup))]

namespace CQRS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            DependencyInjectionConfig.Register(app);
        }
    }
}
