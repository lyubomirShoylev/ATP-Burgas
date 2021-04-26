using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FirstEntityProject.Startup))]
namespace FirstEntityProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
