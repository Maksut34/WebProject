using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public int UserId { get; set; }
        public Users Users { get; set; }
    }
}
