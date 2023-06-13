using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pet.Models;
public class Animal
{
    [Key]
    public int Id { get; set; }
    [Required]
    [StringLength(40)]
    [MinLength(1)]
    public string Name { get; set; }
    [Required]
    [Range(0, 250)]
    public int Age { get; set; }
    [ValidateNever]
    public string ImageUrl { get; set; }
    [ValidateNever]
    public string Description { get; set; }

    public int CategoryId { get; set; }
    [ForeignKey("CategoryId")]
    [ValidateNever]
    public Category Category { get; set; }
}
