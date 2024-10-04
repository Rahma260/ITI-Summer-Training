using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;

namespace program.Models.Entities
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [MinLength(5, ErrorMessage = "Minlength is 5 characters at least")]
        [MaxLength(100, ErrorMessage = "Maxlength is 100 characters")]
        [Required(ErrorMessage = "The name is required")]
        public string UserName { get; set; }
        public int UserAge { get; set; }
        //[DataType(DataType.EmailAddress)]
        //public string UserEmail { get; set; }
        //[DataType(DataType.Password)]
        //[MinLength(6)]
        //[RegularExpression(@"\w & \d")]
        //public string UserPassword { get; set; }
        //[DataType(DataType.Date)]
        [DataType(DataType.Date, ErrorMessage = "The date must contain dd/mm/yyy format")]
        public DateTime UserDate { get; set; }
        //[RegularExpression(@"Male | Female", ErrorMessage ="The gender must be male or female")]
        public string UserGender { get; set; }
        [DataType(DataType.Currency)]
        public decimal UserSalary { get; set; }
        public string UserAddresss { get; set; }
       // [RegularExpression(@"\w + \.(jpg | png)", ErrorMessage ="The extension must be .jpg or .png")]
        public string UserImage { get; set; }

        // [RegularExpression(@"user | admin | author")]
        //public string UserRole { get; set; }
        public ICollection<Post>? Posts { get; set; }
        public int? CategoryId { get; set; }
        public Category? category { get; set; }
    }
}
