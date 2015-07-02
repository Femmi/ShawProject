using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShawProject.Startup))]
namespace ShawProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
