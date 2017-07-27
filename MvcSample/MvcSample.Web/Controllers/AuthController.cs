using System.Web.Mvc;

namespace MvcSample.Web.Controllers
{
    public class AuthController : Controller
    {
        
        public ViewResult Login()
        {
            return View();
        }
    }
}