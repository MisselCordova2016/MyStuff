using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestApplication1.Startup))]
namespace TestApplication1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
