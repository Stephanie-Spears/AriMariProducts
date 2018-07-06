using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AriMariProducts.Startup))]
namespace AriMariProducts
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
