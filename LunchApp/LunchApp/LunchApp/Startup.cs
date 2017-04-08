using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LunchApp.Startup))]
namespace LunchApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
