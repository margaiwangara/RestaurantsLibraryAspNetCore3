using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
    
    public DateTimeOffset DateAdded { get; set; }

    [ForeignKey("MenuId")]
    public Menu Menu { get; set; }

    public Guid MenuId { get; set; }

    public Restaurant()
    {
      DateAdded = DateTimeOffset.Now;
    }
  }
}