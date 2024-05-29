using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Entity.Models
{
    public class Martianas_Values
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string type { get; set; }
        public float MartianaMaxHealth { get; set; }
        public float MartianaHealth { get; set; }
        public bool NoMorehealth { get; set; }

        [ForeignKey("Users")]
        public int UserId { get; set; }
        public Users Users { get; set; }
    }
}
