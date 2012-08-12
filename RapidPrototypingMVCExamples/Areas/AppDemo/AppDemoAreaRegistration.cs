using System.Web.Mvc;

namespace RapidPrototypingMVCExamples.Areas.AppDemo
{
    public class AppDemoAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "AppDemo";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "AppDemo_default",
                "AppDemo/{controller}/{action}/{id}",
                new { action = "Index", controller="app", id = UrlParameter.Optional }
            );
        }
    }
}
