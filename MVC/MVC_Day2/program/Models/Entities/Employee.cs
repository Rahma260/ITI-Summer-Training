using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace program.Models.Entities
{
    public class Employee
    {
 
        public int EmployeeId { get; set; }
        [Required]
        [MaxLength(100)]
        public string EmployeeName { get; set; }
        [Range(22,60)]
        public int EmployeeAge { get; set; }
        public int EmployeeSalary { get; set; }
        public string EmployeeAddress { get; set; }

        [EmailAddress]
        public string EmployeeEmail { get; set; }
        [MaxLength(11)]
        public string EmployeePhone { get; set; }
        [StringLength(10)]
        public string? EmployeeImage { get; set; }
        [ForeignKey(nameof(Company))]
        public int? CompanyId { get; set; }
        public virtual Company? Company { get; set; }
    }
}
