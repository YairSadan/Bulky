using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pet.Models;
public class Comment
{
    [Key]
    public int Id { get; set; }
    [Required]
    [StringLength(200)]
    public string Text { get; set; }
    public int AnimalId { get; set; }
    [ForeignKey("AnimalId")]
    public Animal Animal { get; set; }
}
