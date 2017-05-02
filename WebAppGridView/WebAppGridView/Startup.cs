using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppGridView.Startup))]
namespace WebAppGridView
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
