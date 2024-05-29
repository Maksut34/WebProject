using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Web_Project.Models
{
    public class EditProfileViewModel
    {
        
        public IFormFile image { get; set; }
        
        public string City { get; set; }
        
        public string Country { get; set; }
        
        public string Address { get; set; }
    }
}
