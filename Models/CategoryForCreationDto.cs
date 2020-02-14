using System.Collections.Generic;

namespace AspNetCoreMVCMovie.Models
{
  public class CategoryForCreationDto
  {
    public string Name { get; set; }

    public IEnumerable<CategoryItemForCreationDto> CategoryItem { get; set; }
      = new List<CategoryItemForCreationDto>();
  }
}