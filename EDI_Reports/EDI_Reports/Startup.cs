using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EDI_Reports.Startup))]
namespace EDI_Reports
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
