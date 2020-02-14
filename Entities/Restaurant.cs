using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCoreMVCMovie.Entities
{
  public class Restaurant
  {
    [Key]
    public Guid Id { get; set; }

    public string Name { get;set; }

    public string Address { get; set; }

    public bool OffersTakeout { get; set; }
    
    public DateTimeOffset DateAdded { get; set; }

    public Restaurant()
    {
      DateAdded = DateTimeOffset.Now;
    }
  }
}