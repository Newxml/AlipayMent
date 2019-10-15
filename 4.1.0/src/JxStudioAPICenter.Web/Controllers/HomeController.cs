using Microsoft.AspNetCore.Mvc;

namespace JxStudioAPICenter.Web.Controllers
{
    public class HomeController : JxStudioAPICenterControllerBase
    {
        public ActionResult Index()
        {
            return Redirect("/swagger");
        }

        public ActionResult About()
        {
            return View();
        }
    }
}