using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExamenDNet.Web.Startup))]
namespace ExamenDNet.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
