using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TodoWebsite.Startup))]
namespace TodoWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
