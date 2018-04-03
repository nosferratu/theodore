using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Theodore.Website.Startup))]
namespace Theodore.Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
