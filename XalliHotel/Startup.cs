using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(XalliHotel.Startup))]
namespace XalliHotel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
