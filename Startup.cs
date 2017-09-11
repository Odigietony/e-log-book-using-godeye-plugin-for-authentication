using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LogBookWebApp.Startup))]
namespace LogBookWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
