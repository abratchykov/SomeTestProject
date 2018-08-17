using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SomeTestProject.Startup))]
namespace SomeTestProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
