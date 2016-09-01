using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SensiblyNamedMVCdemo.Startup))]
namespace SensiblyNamedMVCdemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
