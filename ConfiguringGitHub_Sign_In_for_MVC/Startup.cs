using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConfiguringGitHub_Sign_In_for_MVC.Startup))]
namespace ConfiguringGitHub_Sign_In_for_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
