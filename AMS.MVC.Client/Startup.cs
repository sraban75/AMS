using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AMS.MVC.Client.Startup))]
namespace AMS.MVC.Client
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
