using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Unidade2.Startup))]
namespace Unidade2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
