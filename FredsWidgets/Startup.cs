using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FredsWidgets.Startup))]
namespace FredsWidgets
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
