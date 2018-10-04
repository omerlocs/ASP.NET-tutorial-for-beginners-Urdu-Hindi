using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Library.WebUI.Startup))]
namespace Library.WebUI
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
