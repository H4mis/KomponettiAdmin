using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KomponettiAdmin.Startup))]
namespace KomponettiAdmin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
