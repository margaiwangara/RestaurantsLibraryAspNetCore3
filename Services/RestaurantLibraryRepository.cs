using System;
using AspNetCoreMVCMovie.DbContexts;

namespace AspNetCoreMVCMovie.Services
{
  public class RestaurantLibraryRepository
  {
    private readonly RestaurantLibraryContext _context;

    public RestaurantLibraryRepository(RestaurantLibraryContext context)
    {
      _context = context ?? throw new ArgumentNullException(nameof(context));
    }
  }
}