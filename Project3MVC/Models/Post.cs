using System.ComponentModel.DataAnnotations;

namespace Project3MVC.Models
{
    public class Post
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public int ForumId { get; set; }
        [Required]
        public string? TextContent { get; set; }
        public bool isReply { get; set; }
        public int ParentId { get; set; }
    }
}
