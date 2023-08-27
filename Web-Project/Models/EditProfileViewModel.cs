using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Web_Project.Models
{
    public class EditProfileViewModel
    {
        [Required]
        public IFormFile image { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string Address { get; set; }
    }
}
