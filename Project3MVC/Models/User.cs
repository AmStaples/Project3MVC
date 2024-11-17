using System.ComponentModel.DataAnnotations;

namespace Project3MVC.Models
{
    public class User
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string? Username { get; set; }
        [Required]
        public string? email { get; set; }
        [Required]
        public string? password { get; set; }

    }
}
