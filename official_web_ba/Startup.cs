using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(official_web_ba.Startup))]
namespace official_web_ba
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
