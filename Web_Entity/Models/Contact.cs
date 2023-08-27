using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Entity.Models
{
    public class Contact
    {
        [Key] 
        public int contactID { get; set; }
        [Required]
        public string message { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
        [ForeignKey("Users")]
        public int UserID { get; set; }
        public Users Users { get; set; }
    }
}
