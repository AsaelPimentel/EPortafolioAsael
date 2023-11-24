using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EPortafolioAsael.Startup))]
namespace EPortafolioAsael
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
