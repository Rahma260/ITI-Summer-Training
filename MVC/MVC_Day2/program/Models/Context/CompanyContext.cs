using Microsoft.EntityFrameworkCore;
using program.Models.Entities;

namespace program.Models.Context
{
    public class CompanyContext : DbContext
    {
        public CompanyContext() : base() { }
        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options)
        {

        }

        
        public DbSet<Employee> employees { get; set; }
        public DbSet<Company> companies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().Property(d => d.CompanyStartDate)
                .HasDefaultValue(DateTime.Now.AddYears(-6));

            base.OnModelCreating(modelBuilder);
        }
    }
}
