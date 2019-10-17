using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcProjectBankingHcl.Startup))]
namespace MvcProjectBankingHcl
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
