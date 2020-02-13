using System;

namespace AspNetCoreMVCMovie.Models
{
  public class RestaurantDto
  {
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string PostalCode { get; set; }

    public string Street { get; set; }
     
    public long Longitude { get; set; }

    public long Latitude { get; set; }

  }
}