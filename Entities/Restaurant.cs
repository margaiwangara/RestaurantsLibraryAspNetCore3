using System;

namespace AspNetCoreMVCMovie.Entities
{
  public class Restaurant
  {
    public Guid Id { get; set; }

    public string Name { get;set; }

    public string Address { get; set; }

    public bool OffersTakeout { get; set; }
    
    public DateTimeOffset DateAdded { get; set; }

    public Menu Menu { get; set; }

    public Restaurant()
    {
      DateAdded = DateTimeOffset.Now;
    }
  }
}