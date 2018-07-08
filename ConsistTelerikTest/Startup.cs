using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConsistTelerikTest.Startup))]
namespace ConsistTelerikTest
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
