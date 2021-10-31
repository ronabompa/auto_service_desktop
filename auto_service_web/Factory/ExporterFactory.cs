using System;
using System.Collections.Generic;
using System.Composition;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ServiceAutoFINAL.Factory
{
    public class ExporterFactory
    {
       public IExporter GetExporter(string expType)
        {
            if (expType == null)
            {
                return null;
            }
            if (expType.Equals("CSV"))
            {
                return new CsvExporter();

            }
            else if (expType.Equals("JSON"))
            {
                return new JsonExporter();
            }
            else if (expType.Equals("XLS"))
            {
                return new XlsExporter();
            }
           
            return null;
        }
    }
}
