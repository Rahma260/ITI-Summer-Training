using EFDay1.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDay1.Contexts
{
    public class studdept_context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=.; Database=student_dept; Integrated Security = True;Encrypt=True;Trust Server Certificate=True");
        
        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }
        
    }
}
