using Microsoft.EntityFrameworkCore.Migrations;

namespace BookCollection.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                column: "Name",
                value: "J. R. R. Tolkein");

            migrationBuilder.InsertData(
                table: "Authors",
                column: "Name",
                value: "George R. R. Martin");

            migrationBuilder.InsertData(
                table: "Authors",
                column: "Name",
                value: "J. K. Rowling");

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Title", "AuthorName" },
                values: new object[] { "The Hobbit", "J. R. R. Tolkein" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Name",
                keyValue: "George R. R. Martin");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Name",
                keyValue: "J. K. Rowling");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Title",
                keyValue: "The Hobbit");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Name",
                keyValue: "J. R. R. Tolkein");
        }
    }
}
