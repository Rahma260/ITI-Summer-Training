using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDay1.Entities
{
    public partial class Person
    {
        [MinLength(10)]
        [MaxLength(100)]
        [Required]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        public string gender { get; set; }
        prop

    }
}
