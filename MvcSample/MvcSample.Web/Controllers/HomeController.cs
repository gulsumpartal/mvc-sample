using System.Web.Mvc;

namespace MvcSample.Web.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}