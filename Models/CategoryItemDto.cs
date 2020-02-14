using System;

namespace AspNetCoreMVCMovie.Models
{
  public class CategoryItemDto 
  {
    public Guid Id { get; set; }

    public string Name { get; set; } // tea, coffee etc.

    public string Description { get; set; }
  }
}