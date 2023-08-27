using System.ComponentModel.DataAnnotations;

namespace Web_Project.Models
{
    public class AddStoryModels
    {
        [Required]
        [MinLength(1)]
        public string storyname { get; set; }
        [Required]
        public string Types { get; set; }
        [Required]
        [MinLength(1)]
        public string Stories { get; set; }
    }
}
