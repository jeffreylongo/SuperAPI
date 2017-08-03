using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SuperAPI.Startup))]
namespace SuperAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

