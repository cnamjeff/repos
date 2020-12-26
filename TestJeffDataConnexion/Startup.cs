using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestJeffDataConnexion.Startup))]
namespace TestJeffDataConnexion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
