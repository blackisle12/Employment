using Employment.Repository.Entities;
using Microsoft.EntityFrameworkCore;

namespace Employment.Repository
{
    public class ApiContext : DbContext
    {
        public DbSet<Entities.Employment> Employment { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "EmploymentDb");
        }
    }
}
