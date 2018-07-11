using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GUIClient.Startup))]
namespace GUIClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
