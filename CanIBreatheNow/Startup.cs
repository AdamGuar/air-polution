using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CanIBreatheNow.Startup))]
namespace CanIBreatheNow
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
