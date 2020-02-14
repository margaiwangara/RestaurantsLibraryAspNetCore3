using System;
using System.Collections.Generic;

namespace AspNetCoreMVCMovie.Models
{
  public class CategoryDto
  {
    public Guid Id { get; set; }

    public string Name { get; set; }

    public IEnumerable<CategoryItemDto> CategoryItem { get; set; }
      = new List<CategoryItemDto>();
  }
}