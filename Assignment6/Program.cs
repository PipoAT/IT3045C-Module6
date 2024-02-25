using Assignment6.Database;

class Program
{
    static void Main()
    {
        // calling the db context for both queries
        var dbContext = new ApplicationDbContext();

        // retrieve the book and author from database
        var bookAuthorQuery =
            from book in dbContext.Books
            join author in dbContext.Authors on book.AuthorID equals author.AuthorID
            select new
            {
                BookTitle = book.Title,
                AuthorFullName = $"{author.FirstName} {author.LastName}"
            };

        Console.WriteLine("Books with Author:");
        foreach (var result in bookAuthorQuery)
        {
            Console.WriteLine($"Title: {result.BookTitle}, Author: {result.AuthorFullName}");
        }

        Console.WriteLine();

        // retrieve the book and genre information
        var bookGenreQuery =
            from book in dbContext.Books
            join genre in dbContext.Genres on book.GenreID equals genre.GenreID
            select new
            {
                BookTitle = book.Title,
                GenreName = genre.Genre
            };

        Console.WriteLine("Books with Genre:");
        foreach (var result in bookGenreQuery)
        {
            Console.WriteLine($"Title: {result.BookTitle}, Genre: {result.GenreName}");
        }
    }
}
