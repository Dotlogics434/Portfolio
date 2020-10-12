using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VectorWeb.Startup))]
namespace VectorWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
