using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CF.Startup))]
namespace CF
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
