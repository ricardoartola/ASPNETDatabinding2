using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPNETDatabinding2.Startup))]
namespace ASPNETDatabinding2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
