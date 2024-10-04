using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace program.Models.Entities
{
    public class Post
    {

        [Key]
        public int PostId { get; set; }
        [Required(ErrorMessage = "Post title is required")]
        public string PostTitle { get; set; }
        [Required(ErrorMessage = "Post body is required")]
        public string PostBody { get; set; }
        [DataType(DataType.Date, ErrorMessage = "The date must contain dd/mm/yyy format")]
        public DateTime PostDate { get; set; }
        //category type and author name
        //  [RegularExpression(@"\w + \.(jpg | png)", ErrorMessage = "The extension must be .jpg or .png")]
        //public IFormFile? PostImageFile { get; set; }
        public string? PostImage { get; set; }
        public int? UserId { get; set; }
        public User? PostUser { get; set; }
        public int? CategoryId { get; set; }
        public Category? PostCategory { get; set; }
    }
}
