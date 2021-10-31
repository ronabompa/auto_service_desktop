using ServiceAutoFINAL.Entities;
using System.Collections.Generic;
using ServiceStack.Text;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace ServiceAutoFINAL.Factory
{
    public class CsvExporter : IExporter
    {
        public FileStream export(List<Appointment> list)
        {
            string fileName = "appointments.csv";
            FileStream fs = new FileStream(fileName, FileMode.Create);

            string csv = CsvSerializer.SerializeToCsv(list);
            byte[] download = Encoding.UTF8.GetBytes(csv);

            fs.Write(download, 0, download.Length);

            return fs;
        }
    }
}
