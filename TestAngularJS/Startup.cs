using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestAngularJS.Startup))]
namespace TestAngularJS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
