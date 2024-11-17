using Microsoft.EntityFrameworkCore;

namespace Project3MVC.Models
{
    public class Proj3Context : DbContext
    {
        public Proj3Context(DbContextOptions<Proj3Context> options) : base(options) { }

        public DbSet<Forum> Forums { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Forum>().HasData(
                new Forum
                {
                    Id = 1,
                    Description = "Description of Forum 1",
                    Name = "Forum1"
                },
                new Forum
                {
                    Id = 2,
                    Description = "Description of Forum 2",
                    Name = "Forum2"
                }
                );
            modelBuilder.Entity<Post>().HasData(
                new Post
                {
                    Id = 1,
                    UserId = 1,
                    ForumId = 1,
                    TextContent = "User1 posting on Forum 1"
                },
                new Post
                {
                    Id = 2,
                    UserId = 1,
                    ForumId = 2,
                    TextContent = "User1 posting on Forum 2"
                },
                new Post
                {
                    Id = 3,
                    UserId = 2,
                    ForumId = 1,
                    TextContent = "User2 posting on Forum 1"
                },
                new Post
                {
                    Id = 4,
                    UserId = 2,
                    ForumId = 2,
                    TextContent = "User2 posint on Forum 2"
                }
                );
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Username = "User1",
                    email = "User1@localhost.port",
                    password = "password"
                },
                new User
                {
                    Id = 2,
                    Username = "User2",
                    email = "User2@localhost.port",
                    password = "password"
                }
                );
        }
    }
}
