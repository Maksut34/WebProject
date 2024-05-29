using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_Entity.Models;
=======
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> 1058286ea13219f1c102be35469122af732c2ddb

namespace Web_DTO.DTO.UsersLoginDTO
{
    public class UsersLoginDTO
    {
<<<<<<< HEAD
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public string RememberMe { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string surname { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string address { get; set; }
        [Required]
        public string city { get; set; }
        [Required]
        public string country { get; set; }
        [Required]
        public string message { get; set; }

        public List<Image> Images { get; set; }
        public List<AddStory> addStories { get; set; }

=======
        public string Username { get; set; }
        public string Password { get; set; }
        public string RememberMe { get; set; }
        public string ReturnUrl { get; set; }
>>>>>>> 1058286ea13219f1c102be35469122af732c2ddb

    }
}
