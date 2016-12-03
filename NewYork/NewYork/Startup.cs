using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewYork.Startup))]
namespace NewYork
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
