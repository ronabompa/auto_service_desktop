using Microsoft.AspNetCore.Mvc;
using ServiceAutoFINAL.Service;


namespace ServiceAutoFINAL
{
    public class APIController : Controller
    {
       IAppointmentService appointmentService;
        IUserService userService;
        /*
        public APIController(IAppointmentService appointmentService)
        {
            this.appointmentService = appointmentService;
         }
        
          */

        public APIController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        public string Get()
        {
            var appointments = appointmentService.GetAppointments();

            return System.Text.Json.JsonSerializer.Serialize(appointments);

        }

        [HttpGet]
        public ActionResult LoginGet(string username, string password)
        {
            

            if(userService.getUser(username,password) == null)
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
