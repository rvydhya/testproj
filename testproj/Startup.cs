using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testproj.Startup))]
namespace testproj
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
