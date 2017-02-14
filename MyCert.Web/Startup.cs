using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyCert.Web.Startup))]
namespace MyCert.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
