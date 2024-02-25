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
}