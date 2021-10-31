using ServiceAutoFINAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceAutoFINAL.Repositories
{
    public interface IAppointmentRepository : IGenericRepository<Appointment>
    {

    }
    public class AppointmentRepository : GenericRepository<Appointment>, IAppointmentRepository
    {
        MongoContext context;

        public AppointmentRepository(MongoContext dbContext)
           : base(dbContext)
        {
            context = dbContext;
        }


    }
}
