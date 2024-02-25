namespace Assignment6.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Genres")]
public class Genres
{
    [Key]
    public int GenreID { get; set; }
    [MaxLength(50)]
    public string Genre { get; set; }

    public virtual List<Books> Books { get; set; }
}