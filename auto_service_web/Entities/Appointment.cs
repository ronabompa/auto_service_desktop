using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceAutoFINAL.Entities
{
    public class Appointment
    {
        public string client { get; set; }
        public string phone { get; set; }

        [Display(Name = "Appointment Date")]
        [DataType(DataType.DateTime)]
        [Key]
        public DateTime dateTime { get; set; }

        [NotMapped]
        public string dateTimeString { get; set; }
        public string car { get; set; }
        public string problem { get; set; }
        public string status { get; set; }

        public Appointment()
        {

        }

        public Appointment(String client, String phone, DateTime dateTime, String car, String problem, String status)
        {
            this.client = client;
            this.phone = phone;
            this.dateTime = dateTime;
            this.car = car;
            this.problem = problem;
            this.status = status;
        }
    }
}
