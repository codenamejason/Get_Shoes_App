using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NiceShoesWebApplicationMaster.Startup))]
namespace NiceShoesWebApplicationMaster
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
