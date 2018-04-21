using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ex1.Startup))]
namespace ex1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
