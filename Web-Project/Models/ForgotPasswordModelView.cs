using System.ComponentModel.DataAnnotations;

namespace Web_Project.Models
{
    public class ForgotPasswordModelView
    {
        [Required]
        public string Email { get; set; }
    }
}
