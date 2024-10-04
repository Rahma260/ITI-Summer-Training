using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDay1.Entities
{
    public class Department
    {
        [Key]
        public int DepartmentID { get; set; }
        [MaxLength(100)]
        [Required]
        public string DepartmentName { get; set; }
        [MaxLength(100)]
        public string? DepartmentDescription { get; set; }
        public ICollection<Student>? students { get; set; }
    }
}
