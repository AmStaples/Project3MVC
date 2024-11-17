using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project3MVC.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Forums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forums", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ForumId = table.Column<int>(type: "int", nullable: false),
                    TextContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isReply = table.Column<bool>(type: "bit", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Forums",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Description of Forum 1", "Forum1" },
                    { 2, "Description of Forum 2", "Forum2" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "ForumId", "ParentId", "TextContent", "UserId", "isReply" },
                values: new object[,]
                {
                    { 1, 1, 0, "User1 posting on Forum 1", 1, false },
                    { 2, 2, 0, "User1 posting on Forum 2", 1, false },
                    { 3, 1, 0, "User2 posting on Forum 1", 2, false },
                    { 4, 2, 0, "User2 posint on Forum 2", 2, false }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Username", "email", "password" },
                values: new object[,]
                {
                    { 1, "User1", "User1@localhost.port", "password" },
                    { 2, "User2", "User2@localhost.port", "password" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Forums");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
