using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(M3.Startup))]
namespace M3
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
