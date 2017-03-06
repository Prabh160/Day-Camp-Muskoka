using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(daycampprogram.Startup))]
namespace daycampprogram
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
