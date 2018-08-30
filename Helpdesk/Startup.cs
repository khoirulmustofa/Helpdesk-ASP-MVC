using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Helpdesk.Startup))]
namespace Helpdesk
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
