using System.ComponentModel.DataAnnotations;

namespace Web_Project.Models
{
    public class ResetPassword
    {
        [Required]
        public string resettoken { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}
