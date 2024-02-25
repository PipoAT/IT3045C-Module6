using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment6.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorsAuthorID",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_AuthorsAuthorID",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "AuthorsAuthorID",
                table: "Books",
                newName: "GenreID");

            migrationBuilder.AddColumn<int>(
                name: "AuthorID",
                table: "Books",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AuthorsBooks",
                columns: table => new
                {
                    AuthorsAuthorID = table.Column<int>(type: "INTEGER", nullable: false),
                    BooksBookID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorsBooks", x => new { x.AuthorsAuthorID, x.BooksBookID });
                    table.ForeignKey(
                        name: "FK_AuthorsBooks_Authors_AuthorsAuthorID",
                        column: x => x.AuthorsAuthorID,
                        principalTable: "Authors",
                        principalColumn: "AuthorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorsBooks_Books_BooksBookID",
                        column: x => x.BooksBookID,
                        principalTable: "Books",
                        principalColumn: "BookID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BooksGenres",
                columns: table => new
                {
                    BooksBookID = table.Column<int>(type: "INTEGER", nullable: false),
                    GenresGenreID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BooksGenres", x => new { x.BooksBookID, x.GenresGenreID });
                    table.ForeignKey(
                        name: "FK_BooksGenres_Books_BooksBookID",
                        column: x => x.BooksBookID,
                        principalTable: "Books",
                        principalColumn: "BookID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BooksGenres_Genres_GenresGenreID",
                        column: x => x.GenresGenreID,
                        principalTable: "Genres",
                        principalColumn: "GenreID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorsBooks_BooksBookID",
                table: "AuthorsBooks",
                column: "BooksBookID");

            migrationBuilder.CreateIndex(
                name: "IX_BooksGenres_GenresGenreID",
                table: "BooksGenres",
                column: "GenresGenreID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorsBooks");

            migrationBuilder.DropTable(
                name: "BooksGenres");

            migrationBuilder.DropColumn(
                name: "AuthorID",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "GenreID",
                table: "Books",
                newName: "AuthorsAuthorID");

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorsAuthorID",
                table: "Books",
                column: "AuthorsAuthorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorsAuthorID",
                table: "Books",
                column: "AuthorsAuthorID",
                principalTable: "Authors",
                principalColumn: "AuthorID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
