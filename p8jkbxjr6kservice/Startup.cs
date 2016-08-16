using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(p8jkbxjr6kservice.Startup))]

namespace p8jkbxjr6kservice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}