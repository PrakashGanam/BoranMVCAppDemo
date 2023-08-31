using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCsampleprj_brain_gorman.Startup))]
namespace MVCsampleprj_brain_gorman
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
