using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Entity.Models
{
    public class Player_Values
    {
        [Key]
        public int valueID { get; set; }
        public int playerLevel { get; set; }
        public int playerLevel_EXP { get; set; }
        public float player_Health { get; set; }
        public float player_MaxHealth { get; set; }
        public bool NoMorehealth { get; set; }

        [ForeignKey("Users")]
        public int UserId { get; set; }
        public Users Users { get; set; }
    }
}
