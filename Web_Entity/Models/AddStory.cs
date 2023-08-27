using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Entity.Models
{
    public class AddStory
    {
        [Key]
        public int AddStoryId { get; set; }
        
        public string storyname { get; set; }

        
        public string Types { get; set; }

        
        public string Stories { get; set; }
        [ForeignKey("Users")]
        public int UserId { get; set; }
        public Users Users { get; set; }
    }
}
