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
    public class AddStory
    {
        [Key]
        public int AddStoryId { get; set; }
        
<<<<<<< HEAD
        public string storyname { get; set; }
=======
        public string Name { get; set; }
>>>>>>> 1058286ea13219f1c102be35469122af732c2ddb

        
        public string Types { get; set; }

        
        public string Stories { get; set; }
<<<<<<< HEAD
        [ForeignKey("Users")]
=======

>>>>>>> 1058286ea13219f1c102be35469122af732c2ddb
        public int UserId { get; set; }
        public Users Users { get; set; }
    }
}
