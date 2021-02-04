using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetoIntegrador.Startup))]
namespace ProjetoIntegrador
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
