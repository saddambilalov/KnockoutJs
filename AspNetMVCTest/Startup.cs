using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspNetMVCTest.Startup))]
namespace AspNetMVCTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
