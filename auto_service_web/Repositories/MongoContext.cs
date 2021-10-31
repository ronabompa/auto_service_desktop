using Microsoft.EntityFrameworkCore;
using ServiceAutoFINAL.Entities;

namespace ServiceAutoFINAL.Repositories
{
    public class MongoContext : DbContext
    {
        public MongoContext(DbContextOptions<MongoContext> options)
    : base(options)
        { }

        public DbSet<Appointment> Appointment { get; set; }
        public DbSet<User> User { get; set; }

        protected void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // object p = modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMongoDB("Server=127.0.0.1;Port=27017;Database=proiectps;");
            }
        }
    }
}
