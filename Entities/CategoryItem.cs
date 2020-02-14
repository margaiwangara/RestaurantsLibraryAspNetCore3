using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreMVCMovie.Entities
{
  public class CategoryItem 
  {
    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Name { get; set; } // tea, coffee etc.

    [MaxLength(100)]
    public string Description { get; set; }
  }
}