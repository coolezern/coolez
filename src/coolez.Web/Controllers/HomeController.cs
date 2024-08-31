using Microsoft.AspNetCore.Mvc;

namespace coolez.Web.Controllers
{
    public class HomeController : coolezControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}