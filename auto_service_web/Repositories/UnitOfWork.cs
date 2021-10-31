using ServiceAutoFINAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace ServiceAutoFINAL.Repositories
{
        public interface IUnitOfWork
        {
            IGenericRepository<User> User { get; }
            IGenericRepository<Appointment> Appointment { get; }
           // void dispose();
        }

        public class UnitOfWork : IUnitOfWork 
        {
            private GenericRepository<User> _userRepository;
            private GenericRepository<Appointment> _appointmentRepository;

            private MongoContext _dbContext;

            public UnitOfWork(MongoContext dbContext)
            {
                this._dbContext = dbContext;
            }
            
           public IGenericRepository<User> User
           {
               get
               {
                   return _userRepository ??
                       (_userRepository = new GenericRepository<User>(_dbContext));
               }
           }
           

           public IGenericRepository<Appointment> Appointment
            {
                get
                {
                    return _appointmentRepository ??
                        (_appointmentRepository = new GenericRepository<Appointment>(_dbContext));
                }
            }

            /*
            public void dispose()
            {
                
            }
            */
        }
    
}
