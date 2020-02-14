using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreMVCMovie.Entities
{
  public class Category
  {

    [Key]
    public Guid Id { get; set; }

    public string Name { get; set; }

    public IEnumerable<CategoryItem> CategoryItem {get; set; }
      = new List<CategoryItem>();
  }
}