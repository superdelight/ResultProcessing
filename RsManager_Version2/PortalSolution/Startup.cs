using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PortalSolution.Startup))]
namespace PortalSolution
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
