using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewVS2015Project.Startup))]
namespace NewVS2015Project
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
