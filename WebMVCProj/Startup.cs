using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebMVCProj.Startup))]
namespace WebMVCProj
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
