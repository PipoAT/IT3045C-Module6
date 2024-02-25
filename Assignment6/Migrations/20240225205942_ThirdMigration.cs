using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assignment6.Migrations
{
    /// <inheritdoc />
    public partial class ThirdMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Books");

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorID", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Andrew", "Pipo" },
                    { 2, "Steve", "Jobs" },
                    { 3, "Bruce", "Wayne" },
                    { 4, "Bob", "Builder" },
                    { 5, "Santa", "Claus" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookID", "AuthorID", "GenreID", "ISBN", "Title" },
                values: new object[,]
                {
                    { 1, 1, 1, "1", "Book 1" },
                    { 2, 2, 2, "2", "Book 2" },
                    { 3, 3, 3, "3", "Book 3" },
                    { 4, 4, 4, "4", "Book 4" },
                    { 5, 5, 5, "5", "Book 5" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreID", "Genre" },
                values: new object[,]
                {
                    { 1, "Fiction" },
                    { 2, "Non-Fiction" },
                    { 3, "Mystery" },
                    { 4, "Comedy" },
                    { 5, "Romance" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: 5);

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Books",
                type: "TEXT",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Books",
                type: "TEXT",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
