using Assignment6.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Assignment6.Database;

public class ApplicationDbContext:DbContext
{
    public DbSet<Authors> Authors { get; set; }
    public DbSet<Books> Books { get; set; }
    public DbSet<Genres> Genres {get; set; }

    public string DbPath { get; set; }

    public ApplicationDbContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = Path.Join(path, "library.db");

    }
    
    protected override  void OnConfiguring(DbContextOptionsBuilder options)
    {
        if(!options.IsConfigured)
        {
            options.UseSqlite($"Data Source={DbPath}");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Authors>().HasData(
            new Authors { AuthorID = 1, FirstName = "Andrew", LastName = "Pipo" },
            new Authors { AuthorID = 2, FirstName = "Steve", LastName = "Jobs" },
            new Authors { AuthorID = 3, FirstName = "Bruce", LastName = "Wayne" },
            new Authors { AuthorID = 4, FirstName = "Bob", LastName = "Builder" },
            new Authors { AuthorID = 5, FirstName = "Santa", LastName = "Claus" }
        );

        modelBuilder.Entity<Genres>().HasData(
            new Genres { GenreID = 1, Genre = "Fiction" },
            new Genres { GenreID = 2, Genre = "Non-Fiction" },
            new Genres { GenreID = 3, Genre = "Mystery" },
            new Genres { GenreID = 4, Genre = "Comedy"},
            new Genres { GenreID = 5, Genre = "Romance"}
        );

        modelBuilder.Entity<Books>().HasData(
            new Books { BookID = 1, Title = "Book 1", ISBN = "1", Author = "Andrew Pipo", AuthorID = 1, GenreID = 1 },
            new Books { BookID = 2, Title = "Book 2", ISBN = "2", Author = "Steve Jobs", AuthorID = 2, GenreID = 2 },
            new Books { BookID = 3, Title = "Book 3", ISBN = "3", Author = "Bruce Wayne", AuthorID = 3, GenreID = 3 },
            new Books { BookID = 4, Title = "Book 4", ISBN = "4", Author = "Bob Builder", AuthorID = 4, GenreID = 4 },
            new Books { BookID = 5, Title = "Book 5", ISBN = "5", Author = "Santa Claus", AuthorID = 5, GenreID = 5 }
        );
    }
}