using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreMVCMovie.Entities
{
  public class CategoryItem 
  {
    [Key]
    public Guid Id { get; set; }

    public string Name {get; set; }

    public string Description {get; set; }
  }
}