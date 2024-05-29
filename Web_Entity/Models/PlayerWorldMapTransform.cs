using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Entity.Models
{
    public class PlayerWorldMapTransform
    {
        [Key]
        public int worlMaptransformID { get; set; }
        public bool worlMaptransformIsHome { get; set; }
        public bool worlMaptransformIsLittleForest { get; set; }
        public bool worlMaptransformIsTown { get; set; }
        

        [ForeignKey("Users")]
        public int UserId { get; set; }
        public Users Users { get; set; }
    }
}
