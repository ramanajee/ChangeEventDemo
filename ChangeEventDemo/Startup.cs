using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChangeEventDemo.Startup))]
namespace ChangeEventDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
