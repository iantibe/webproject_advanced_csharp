using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(websitecsharp.web.Startup))]
namespace websitecsharp.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
