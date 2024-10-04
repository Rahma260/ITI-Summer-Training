using System.ComponentModel.DataAnnotations;

namespace program.Models.Entities
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }
        [Required]
        [MaxLength(100)]
        public string CompanyName { get; set; }
        [Required]
        public string CompanyType { get; set; }
        public string CompanyStartDate { get; set; }
        public string CompanyAddress { get; set; }
        public virtual List<Employee>? Employees { get; set; }
    }
}
