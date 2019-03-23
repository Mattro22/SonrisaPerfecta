using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SonrisaPerfecta.Startup))]
namespace SonrisaPerfecta
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
