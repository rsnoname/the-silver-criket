using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(the_silver_criket.Startup))]
namespace the_silver_criket
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
