namespace Assignment6.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Books")]
public class Books
{
    [Key]
    public int BookID { get; set; }

    [MaxLength(50)]
    public string ISBN { get; set; }
    [MaxLength(50)]
    public string Title { get; set; }
    [MaxLength(50)]
    public string Author {get; set; }

    public int AuthorID { get; set; }
    public int GenreID { get; set; } 

    public virtual List<Authors> Authors { get; set; }

    public virtual List<Genres> Genres { get; set; }

}