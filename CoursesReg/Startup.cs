using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CoursesReg.Startup))]
namespace CoursesReg
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
