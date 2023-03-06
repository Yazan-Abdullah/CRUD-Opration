using Microsoft.EntityFrameworkCore;
using WebAppCrudOperation.Models;

namespace WebAppCrudOperation.Data
{
    public class DBApplecationContext : DbContext
    {
        public DBApplecationContext(DbContextOptions<DBApplecationContext> options): base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Employee>().ToTable("Employees", "HR");
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
