using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitMVC.Startup))]
namespace GitMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
