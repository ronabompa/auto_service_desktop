using Newtonsoft.Json.Linq;
using ServiceAutoFINAL.Entities;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace ServiceAutoFINAL.Factory
{
    public class JsonExporter : IExporter
    {
        public FileStream export(List<Appointment> list)
        {
            string fileName = "appointments.json";
            FileStream fs = new FileStream(fileName, FileMode.Create);

            string json = JsonConvert.SerializeObject(list, Formatting.Indented);
            byte[] download = Encoding.UTF8.GetBytes(json);

            fs.Write(download, 0, download.Length);
           
            return fs;
        }


    }
}
