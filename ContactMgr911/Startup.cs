using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContactMgr911.Startup))]
namespace ContactMgr911
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
