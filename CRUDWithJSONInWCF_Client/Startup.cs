using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CRUDWithJSONInWCF_Client.Startup))]
namespace CRUDWithJSONInWCF_Client
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // ConfigureAuth(app);
        }
    }
}
