using System;
using System.Collections.Generic;

namespace AspNetCoreMVCMovie.Models
{
  public class MenuDto
  {
    public Guid Id { get; set; }
    public IEnumerable<CategoryDto> Category { get; set; }
        = new List<CategoryDto>();
  }
}