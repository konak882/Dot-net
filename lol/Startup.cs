using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lol.Startup))]
namespace lol
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
