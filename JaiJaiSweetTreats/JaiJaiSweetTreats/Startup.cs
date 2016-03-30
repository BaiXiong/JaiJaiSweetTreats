using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JaiJaiSweetTreats.Startup))]
namespace JaiJaiSweetTreats
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
