using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreMVCMovie.Entities
{
  public class Category
  {

    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Name { get; set; }

    public IEnumerable<CategoryItem> CategoryItem {get; set; }
      = new List<CategoryItem>();
  }
}