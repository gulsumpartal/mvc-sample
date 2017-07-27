using System.Web.Mvc;
using MvcSample.Web.Filters;

namespace MvcSample.Web.Controllers
{
    [UserAuthFilter]
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}