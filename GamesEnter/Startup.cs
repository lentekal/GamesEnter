using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GamesEnter.Startup))]
namespace GamesEnter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
