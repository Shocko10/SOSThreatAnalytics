using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SOSThreatAnalytics.Startup))]
namespace SOSThreatAnalytics
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
