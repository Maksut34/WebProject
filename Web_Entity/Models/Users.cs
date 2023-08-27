using Microsoft.AspNetCore.Identity;
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
        public int UsersInformationId { get; set; }
        public Users_İnformation Users_Information { get; set; }
        public List<Image> Images { get; set; }
        public List<AddStory> AddStory { get; set; }

    }
}
