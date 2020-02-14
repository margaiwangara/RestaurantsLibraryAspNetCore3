using AspNetCoreMVCMovie.Entities;

namespace AspNetCoreMVCMovie.Models
{
  public class RestaurantForCreationDto
  {
    public string Name { get; set; }
    public string Address { get; set; }
    public bool OffersTakeout { get; set; }
    public Menu Menu { get; set; }
  }
}