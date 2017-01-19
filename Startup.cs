using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(affnt.Startup))]
namespace affnt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
