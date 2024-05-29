using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations.Schema;
=======
>>>>>>> 1058286ea13219f1c102be35469122af732c2ddb
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Entity.Models
{
    public class Image
    {
        [Key]
        public int image_ID { get; set; }
       
        public string image { get; set; }
<<<<<<< HEAD
        [ForeignKey("Users")]
=======

>>>>>>> 1058286ea13219f1c102be35469122af732c2ddb
        public int UserId { get; set; }
        public Users Users { get; set; }
    }
}
