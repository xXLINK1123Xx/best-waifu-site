using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bestwaifu.Startup))]
namespace Bestwaifu
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
