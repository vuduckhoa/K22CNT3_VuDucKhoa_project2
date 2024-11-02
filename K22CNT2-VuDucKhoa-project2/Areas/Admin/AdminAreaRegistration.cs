using System.Web.Mvc;

namespace K22CNT2_VuDucKhoa_project2.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "K22CNT2_VuDucKhoa_project2.Areas.Admin.Controllers" }
            );
        }
    }
}