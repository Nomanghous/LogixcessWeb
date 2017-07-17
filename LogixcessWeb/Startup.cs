using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LogixcessWeb.Startup))]
namespace LogixcessWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
