using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreMVCMovie.Entities
{
  public class Menu
  {
    [Key]
    public Guid Id { get; set; }

    public IEnumerable<Category> Category { get; set; }
        = new List<Category>();
  }
}