using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ZFighters.Startup))]
namespace ZFighters
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
