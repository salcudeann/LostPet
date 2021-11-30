using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LostPet.Startup))]
namespace LostPet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
