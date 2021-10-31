using ServiceAutoFINAL.Entities;
using System;
using System.Collections.Generic;
using System.Composition;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceAutoFINAL.Factory
{
    public interface IExporter
    {
        public FileStream export(List<Appointment> list);
    }
}
