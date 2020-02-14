using System;

namespace AspNetCoreMVCMovie.Models
{
  public class RestaurantDto
  {
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public bool OffersTakeout { get; set; }

    public DateTime DateCreated { get; set; }

    // public Guid MenuId { get; set; }

  }
}