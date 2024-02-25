using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment6.Migrations
{
    /// <inheritdoc />
    public partial class FourthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Books",
                type: "TEXT",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 1,
                column: "Author",
                value: "Andrew Pipo");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 2,
                column: "Author",
                value: "Steve Jobs");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 3,
                column: "Author",
                value: "Bruce Wayne");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 4,
                column: "Author",
                value: "Bob Builder");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 5,
                column: "Author",
                value: "Santa Claus");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "Books");
        }
    }
}
