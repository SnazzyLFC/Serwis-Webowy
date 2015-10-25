using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProduktyWebSerwis.Startup))]
namespace ProduktyWebSerwis
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
