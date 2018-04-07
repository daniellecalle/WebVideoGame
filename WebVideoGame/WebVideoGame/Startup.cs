using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebVideoGame.Startup))]
namespace WebVideoGame
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
