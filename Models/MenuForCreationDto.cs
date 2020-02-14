using System.Collections.Generic;

namespace AspNetCoreMVCMovie.Models
{
  public class MenuForCreationDto 
  {
    public IEnumerable<CategoryForCreationDto> Category { get; set; }
        = new List<CategoryForCreationDto>();
  }
}