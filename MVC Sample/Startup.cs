using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Sample.Startup))]
namespace MVC_Sample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
