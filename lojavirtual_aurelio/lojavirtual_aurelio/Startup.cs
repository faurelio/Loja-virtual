using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lojavirtual_aurelio.Startup))]
namespace lojavirtual_aurelio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
