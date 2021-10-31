using System;
namespace ServiceAutoDESKTOP.Entities
{
    public class Appointment
    {
        public string client { get; set; }
        public string phone { get; set; }
        public DateTime dateTime { get; set; }
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

