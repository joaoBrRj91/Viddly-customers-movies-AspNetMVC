using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(viddly.Startup))]
namespace viddly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
