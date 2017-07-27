using System.Web.Mvc;
using MvcSample.Common.Helpers;
using MvcSample.Core.Services;
using MvcSample.DTO.Auth;

namespace MvcSample.Web.Controllers
{
    public class AuthController : Controller
    {

        public ViewResult Login()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Login(LoginUserDto dto)
        {
            var userData = new UserService().GetUserDetails(dto);

            if (userData == null)
            {
                return Json("ERROR");
            }

            UserHelper.CurrentUser = userData;

            return Json("OK");
        }


        //Login UserService.GetUserDetails(dto) 
    }
}