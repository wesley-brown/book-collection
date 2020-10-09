using Microsoft.EntityFrameworkCore.Migrations;

namespace BookCollection.Migrations
{
    public partial class Books : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Title", "AuthorName" },
                values: new object[,]
                {
                    { "The Lord of the Rings", "J. R. R. Tolkein" },
                    { "A Game of Thrones", "George R. R. Martin" },
                    { "A Clash of Kings", "George R. R. Martin" },
                    { "Harry Potter and the Philosopher's Stone", "J. K. Rowling" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Title",
                keyValue: "A Clash of Kings");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Title",
                keyValue: "A Game of Thrones");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Title",
                keyValue: "Harry Potter and the Philosopher's Stone");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Title",
                keyValue: "The Lord of the Rings");
        }
    }
}
