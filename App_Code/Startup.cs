using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Patient.Startup))]
namespace Patient
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
