using Microsoft.EntityFrameworkCore;
using ServiceAutoFINAL.Entities;
using MongoDB.Driver;

namespace ServiceAutoFINAL.Repositories
{
    public class ServiceAutoContext : DbContext
    {
        public DbSet<Appointment> Appointment { get; set; }
        public DbSet<User> User { get; set; }

        public ServiceAutoContext()
        {

        }
        public ServiceAutoContext(DbContextOptions<ServiceAutoContext> options)
        : base(options)
            { }

        protected void OnModelCreating(DbModelBuilder modelBuilder)
        {
           // object p = modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-5T9GP8C\\SQLEXPRESS;Initial Catalog=pstema2;Integrated Security=True");
        }

    }


}

