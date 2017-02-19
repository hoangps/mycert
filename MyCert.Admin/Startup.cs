using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyCert.Admin.Startup))]
namespace MyCert.Admin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
