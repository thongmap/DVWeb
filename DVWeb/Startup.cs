using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DVWeb.Startup))]
namespace DVWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
