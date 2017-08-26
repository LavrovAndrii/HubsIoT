using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HubsIoT.Startup))]
namespace HubsIoT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
