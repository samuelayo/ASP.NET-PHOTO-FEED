using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Real_time_photo_feed.Startup))]
namespace Real_time_photo_feed
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
