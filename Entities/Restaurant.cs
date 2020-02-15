using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreMVCMovie.Entities
{
  public class Restaurant
  {
    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get;set; }

    [Required]
    [MaxLength(100)]
    public string Address { get; set; }

    public bool OffersTakeout { get; set; }
    
    public DateTime DateAdded { get; set; }

    public ICollection<Menu> Menus { get; set; }
       = new List<Menu>();  


  }
}