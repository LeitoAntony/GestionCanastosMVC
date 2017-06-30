using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GestionCanastosMVC.Startup))]
namespace GestionCanastosMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
