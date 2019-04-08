using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClientEshop.Startup))]
namespace ClientEshop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
