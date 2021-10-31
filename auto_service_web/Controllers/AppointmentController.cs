using System;
using Microsoft.AspNetCore.Mvc;
using ServiceAutoFINAL.Entities;
using ServiceAutoFINAL.Service;
using ServiceAutoFINAL.Models;
using System.Text;
using Newtonsoft.Json;
using System.IO;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ServiceAutoFINAL.Controllers
{
    public class AppointmentController : Controller
    {
        IAppointmentService appointmentService;

        public AppointmentController(IAppointmentService appointmentService)
        {
            this.appointmentService = appointmentService;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }


        // GET: Appointment/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Appointment/Create
        [HttpPost]
        public ActionResult CreatePost(Appointment ap)
        {
            if(appointmentService.makeAppointment(ap.client, ap.phone, ap.dateTime, ap.car, ap.problem, ap.status))
            {
                return RedirectToAction("AllAppointments");
            }
            else
            {
                return RedirectToAction("Create");
            }

        }


        // GET: Appointment/Edit
        public IActionResult Edit(DateTime dateTime)
        {
            if (dateTime == null)
            {
                return NotFound();
            }

            Appointment appointment = appointmentService.GetAppointment(dateTime);
            if (appointment == null)
            {
                return NotFound();
            }

            appointment.dateTimeString = appointment.dateTime.ToString("yyyy-MM-dd HH:mm");
            return View(appointment);
        }
        
        // POST: Appointment/Edit
        [HttpPost]
        public ActionResult Edit(Appointment ap)
        {
            ap.dateTime = DateTime.ParseExact(ap.dateTimeString, "yyyy-MM-dd HH:mm",
                                        System.Globalization.CultureInfo.InvariantCulture);
           
            if (appointmentService.updateAppointment(ap.dateTime,ap.status))
            {
                return RedirectToAction("AllAppointments");
            }
            else
            {
                return RedirectToAction("Edit");
            }
        }


        // GET: Appointment/FilterAppointments
        public IActionResult AllAppointments()
        {
            ApViewModel apViewModel = new ApViewModel();
            apViewModel.Appointments = appointmentService.GetAppointments();

            return View(apViewModel);
        }

        // POST: Appointment/FilterAppointments
        [HttpPost]
        public IActionResult AllAppointmentsPost(string searchString1, string searchString2, string filterType)
        {
            ApViewModel apViewModel;

            switch (filterType)
            {

                case "Client":
                    ApViewModel apViewModelClients = new ApViewModel
                    {
                        Appointments = appointmentService.getClientAppointments(searchString1)
                    };
                    apViewModel = apViewModelClients;
                    break;

                case "Day":
                    ApViewModel apViewModelOneDay = new ApViewModel();
                    apViewModelOneDay.Appointments = appointmentService.getAppointmentsForOneDay(DateTime.ParseExact(searchString1, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture));
                    apViewModel = apViewModelOneDay;
                    break;

                case "Between2Dates":
                    ApViewModel apViewModel2Dates = new ApViewModel();
                    apViewModel2Dates.Appointments = appointmentService.getAppointmentsBetween2Dates(DateTime.ParseExact(searchString1, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture), DateTime.ParseExact(searchString2, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture));
                    apViewModel = apViewModel2Dates;
                    break;

                case "All":
                    ApViewModel apViewModelAll = new ApViewModel();
                    apViewModelAll.Appointments = appointmentService.GetAppointments();
                    apViewModel = apViewModelAll;
                    break;

                default:
                    ApViewModel apViewModelAllDefault = new ApViewModel();
                    apViewModelAllDefault.Appointments = appointmentService.GetAppointments();
                    apViewModel = apViewModelAllDefault;
                    break;
            }
                          
            return View("AllAppointments", apViewModel);
        }

        [HttpGet]
        public IActionResult Export(string expType)
        {
            FileStream fs = appointmentService.Export(expType);
            string fileType = "text/" + Path.GetExtension(fs.Name).Split(".")[1];
            string fileName = "appointments" + Path.GetExtension(fs.Name);

            Response.Headers.Add("Content-Disposition", "attachment; filename=" + fileName);
            Response.Headers.Add("X-Content-Type-Options", "nosniff");

            fs.Position = 0;

            return File(fs, fileType, fileName);
        }

    }
}
