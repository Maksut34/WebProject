using Microsoft.AspNetCore.Identity;
<<<<<<< HEAD
using Microsoft.EntityFrameworkCore;
=======
>>>>>>> 1058286ea13219f1c102be35469122af732c2ddb
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Entity.Models
{
    public class Users:IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int confirmemailcode { get; set; }
        public string ConfirmPassword { get; set; }
<<<<<<< HEAD
        public string Password { get; set; }
        public bool userIsActive { get; set; }
        public int UsersInformationId { get; set; }
        public Users_İnformation Users_Information { get; set; }
        public Player_Values players { get; set; }
        public PlayerWorldMapTransform playerWorldMapTransforms { get; set; }
=======
        public int UsersInformationId { get; set; }
        public Users_İnformation Users_Information { get; set; }
>>>>>>> 1058286ea13219f1c102be35469122af732c2ddb
        public List<Image> Images { get; set; }
        public List<AddStory> AddStory { get; set; }

    }
}
