using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCoreMVCMovie.Entities
{
  public class Menu
  {
    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Name { get; set; }
    [ForeignKey("RestaurantId")]
    public Restaurant Restaurant {get; set; }
    public Guid RestaurantId { get; set; }

    // public IEnumerable<MenuItem> Category { get; set; } // drinks, desert etc.
    //     = new List<MenuItem>();
  }
}