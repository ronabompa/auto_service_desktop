using Microsoft.AspNetCore.Mvc;
using ServiceAutoFINAL.Models.Users;
using ServiceAutoFINAL.Service;
using ServiceAutoFINAL.Repositories;
using ServiceAutoFINAL.Entities;
using System.Linq;
using ServiceAutoFINAL.Models;
using System.Diagnostics;
using Microsoft.Extensions.Logging;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ServiceAutoFINAL.Controllers
{
    public class UserController : Controller
    {
       
        IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        /*
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }
        */

        // GET: /<controller>/
        public IActionResult Index()  
        {
            return View();
        }


        // GET: User/Login
        public IActionResult Login()
        {
              return View();
        }

        // POST: User/Login
        [HttpPost]  
        public ActionResult LoginPost(LoginModel model)
        {
            if (userService.getUser(model.username, model.password) != null)
            {
                return RedirectToAction("AllAppointments", "Appointment", new { area = "" });
            }
            else
            {
                return RedirectToAction("Login");
            }
        }


        // GET: User/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult CreatePost(CreateUserModel model)
        {
           if(userService.createUser(model.username, model.password, model.name))
            {
                return RedirectToAction("Login");
            }
           else
            {
                return RedirectToAction("Create");
            }
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
