using Newtonsoft.Json;
using ServiceAutoDESKTOP.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace ServiceAutoDESKTOP.BL
{

    public interface IAppointmentService
    {
        List<Appointment> getAllAppointments();
    }

    public class AppointmentService : IAppointmentService
    {
      
        string uri = "https://localhost:44384/APIAppointments/Get";
        public List<Appointment> getAllAppointments()
        {
            List<Appointment> appointmentList = new List<Appointment>();

            try
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(uri);
                request.Method = "GET";
                var response = request.GetResponse();

                Stream stream = response.GetResponseStream();

                // System.Text.Json.JsonSerializer.

                JsonSerializer serializer = new JsonSerializer();
                serializer.NullValueHandling = NullValueHandling.Ignore;

                using (var sr = new StreamReader(stream))
                using (var jsonTextReader = new JsonTextReader(sr))
                {
                    appointmentList = (List<Appointment>) serializer.Deserialize(jsonTextReader, typeof(List<Appointment>));
                }
                
                if (appointmentList != null)
                {
                    return appointmentList;
                }
                else
                {
                    return new List<Appointment>();
                }

            }
            catch (Exception e)
            {
                return new List<Appointment>();
            }

            return appointmentList;
        }





    }
}
