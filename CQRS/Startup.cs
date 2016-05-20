using Autofac;
using CQRS.DependencyInjection;
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

            var conatinerBuilder = new ContainerBuilder();
            Registration.Register(conatinerBuilder);

            conatinerBuilder.Build();
        }
    }
}
