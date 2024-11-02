using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(K22CNT2_VuDucKhoa_project2.Startup))]
namespace K22CNT2_VuDucKhoa_project2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
