<<<<<<< HEAD
﻿using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Web_Project.Models
{
    public class EditProfileViewModel
    {
        
        public IFormFile image { get; set; }
        
        public string City { get; set; }
        
        public string Country { get; set; }
        
=======
﻿namespace Web_Project.Models
{
    public class EditProfileViewModel
    {
        public string City { get; set; }
        public string Country { get; set; }
>>>>>>> 1058286ea13219f1c102be35469122af732c2ddb
        public string Address { get; set; }
    }
}
