using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceAutoFINAL.Models
{
    public class CreateAppointmentViewModel
    {
        [StringLength(20, MinimumLength = 2)]
        [Required]
        public string client { get; set; }


        [StringLength(20, MinimumLength = 8)]
        [Required]
        public string phone { get; set; }

        [Display(Name = "Appointment Date")]
        [DataType(DataType.DateTime)]
        [Key]
        [Required]
        public DateTime dateTime { get; set; }

        [StringLength(100, MinimumLength = 1)]
        [Required]
        public string car { get; set; }

        [StringLength(5000, MinimumLength = 1)]
        [Required]
        public string problem { get; set; }
       

        [Required]
        public string status { get; set; }
    }
}
