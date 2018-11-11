using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebPolyclinic.Startup))]
namespace WebPolyclinic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            //justcomm

        }
    }
}
