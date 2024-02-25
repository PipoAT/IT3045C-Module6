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
    [MaxLength(50)]
    public string Genre { get; set; }

    public virtual Authors Authors { get; set; }

}