using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LunchAndLearnDI.Startup))]
namespace LunchAndLearnDI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
