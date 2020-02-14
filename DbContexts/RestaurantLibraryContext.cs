using System;
using Microsoft.EntityFrameworkCore;
using AspNetCoreMVCMovie.Entities;

namespace AspNetCoreMVCMovie.DbContexts
{
  public class RestaurantLibraryContext: DbContext
  { 
    public RestaurantLibraryContext(DbContextOptions<RestaurantLibraryContext> options): base(options){}

    public DbSet<Restaurant> Restaurants { get; set; }

  }
}