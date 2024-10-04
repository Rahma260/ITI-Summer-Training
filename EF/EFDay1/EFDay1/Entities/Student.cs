using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDay1.Entities
{
    public class Student
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }
       
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Range(18, 55)]
        public int Age { get; set; }
        [ForeignKey(nameof(Department))]
        public int? DepartmentID { get; set; }
        public Department? Department { get; set; }

    }
}
