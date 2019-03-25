using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AssignmentFinal.Startup))]
namespace AssignmentFinal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
