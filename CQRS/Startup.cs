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
        }
    }
}
