using System.ComponentModel.DataAnnotations;

namespace Project3MVC.Models
{
    public class Forum
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }

    }
}
