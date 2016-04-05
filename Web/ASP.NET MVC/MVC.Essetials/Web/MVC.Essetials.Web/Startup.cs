using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC.Essetials.Web.Startup))]

namespace MVC.Essetials.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            this.ConfigureAuth(app);
        }
    }
}
