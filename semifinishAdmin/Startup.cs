using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(semifinishAdmin.Startup))]
namespace semifinishAdmin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
