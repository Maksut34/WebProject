using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Entity.Models
{
    public class Users_İnformation
    {
        
        public int Id { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }

        public int UserId { get; set; } 
        public Users Users { get; set; }

    }
}
