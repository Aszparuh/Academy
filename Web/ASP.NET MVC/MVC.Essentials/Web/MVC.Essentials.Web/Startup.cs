using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC.Essentials.Web.Startup))]

namespace MVC.Essentials.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            this.ConfigureAuth(app);
        }
    }
}
