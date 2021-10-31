using Microsoft.AspNetCore.Mvc;
using ServiceAutoFINAL.Service;

namespace ServiceAutoFINAL.API
{
    public class APIAppointmentsController : Controller
    {
        IAppointmentService appointmentService;
        
        public APIAppointmentsController(IAppointmentService appointmentService)
        {
            this.appointmentService = appointmentService;
         }
        
       
        [HttpGet]
        public string Get()
        {
            var appointments = appointmentService.GetAppointments();

            return System.Text.Json.JsonSerializer.Serialize(appointments);

        }

    }
}
