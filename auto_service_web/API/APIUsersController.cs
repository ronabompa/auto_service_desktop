using DocumentFormat.OpenXml.Presentation;
using Microsoft.AspNetCore.Mvc;
using ServiceAutoFINAL.Service;

namespace ServiceAutoFINAL.API
{
    public class APIUsersController : Controller
    {

        IUserService userService;
       
        public APIUsersController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        public ActionResult LoginGet(string username, string password)
        {
            if (userService.getUser(username, password) == null)
            {
                return Json(false);
            }
            else
            {
                return Json(true);
            }

        }

    }
}
