using ServiceAutoFINAL.Entities;
using System.Collections.Generic;
using ServiceStack.Text;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Data;
using System.ComponentModel;
using System;
using Excel;

namespace ServiceAutoFINAL.Factory
{
    public class XlsExporter : IExporter
    {
        // var 3
        private DataTable ToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }

        public FileStream export(List<Appointment> list)
        {
            string fileName = "appointments.xls";
            FileStream fs = new FileStream(fileName, FileMode.Create);

            //var 2
         //   System.Data.DataTable dataTable = ToDataTable(list);
          // DataSet dataSet = new DataSet();

         //   dataSet.Tables.Add(dataTable);

         //   ExcelLibrary.DataSetHelper.CreateWorkbook(fileName, dataSet);

            // var 1
            //   string xls = CsvSerializer.SerializeToCsv(list);
            //  byte[] download = Encoding.UTF8.GetBytes(xls);

            byte[] download = ArrayToExcelExtensions.ToExcel(list);

            fs.Write(download, 0, download.Length);

            return fs;
        }
    }
}

