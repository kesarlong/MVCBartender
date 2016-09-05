using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCBartender.Startup))]
namespace MVCBartender
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
