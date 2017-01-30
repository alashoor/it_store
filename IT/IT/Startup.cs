using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IT.Startup))]
namespace IT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
