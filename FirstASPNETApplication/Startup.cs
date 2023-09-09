using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FirstASPNETApplication.Startup))]
namespace FirstASPNETApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
