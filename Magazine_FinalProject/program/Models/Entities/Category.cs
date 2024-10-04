using System.ComponentModel.DataAnnotations;

namespace program.Models.Entities
{ 
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Category name is required")]
        public string CategoryName { get; set; }
        [Required(ErrorMessage = "Creation date is required")]
        [DataType(DataType.Date, ErrorMessage = "The date must be in the format dd/mm/yyyy")]
        [DateInRange(2000, 2024)]
        public DateTime CategoryDate { get; set; }
        public ICollection<User>? users { get; set; }
        public ICollection<Post>? posts { get; set; }
    }
}
