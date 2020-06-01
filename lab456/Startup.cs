using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab456.Startup))]
namespace lab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
