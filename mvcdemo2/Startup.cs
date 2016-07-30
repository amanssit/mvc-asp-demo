using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcdemo2.Startup))]
namespace mvcdemo2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
