namespace Assignment6.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Authors")]
public class Authors
{
    [Key]
    public int AuthorID { get; set; }
    
    [MaxLength(50)]
    public string FirstName { get; set; }
    [MaxLength(50)]
    public string LastName { get; set; }

    public virtual List<Books> Books { get; set; }
}