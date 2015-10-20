using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzurreWebAppDB1.Startup))]
namespace AzurreWebAppDB1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
