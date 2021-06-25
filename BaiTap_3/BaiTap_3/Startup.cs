using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BaiTap_3.Startup))]
namespace BaiTap_3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
