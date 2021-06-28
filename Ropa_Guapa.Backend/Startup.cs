using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ropa_Guapa.Backend.Startup))]
namespace Ropa_Guapa.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
