using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BankingKataMVC.Startup))]
namespace BankingKataMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
