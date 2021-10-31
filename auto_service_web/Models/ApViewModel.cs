using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ServiceAutoFINAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceAutoFINAL.Models
{
    public class ApViewModel
    {
        public List<Appointment> Appointments { get; set; }

        public string FilterType { get; set; }
       
        [BindProperty(SupportsGet = true)]
        public string SearchString1 { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString2 { get; set; }

       // [BindProperty(SupportsGet = true)]
        public string expType { get; set; }

    }
}
