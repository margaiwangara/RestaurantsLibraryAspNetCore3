using System;
using System.Collections.Generic;
using AspNetCoreMVCMovie.Entities;
using AspNetCoreMVCMovie.DbContexts;
using System.Linq;

namespace AspNetCoreMVCMovie.Services
{
  public class RestaurantLibraryRepository: IRestaurantLibraryRepository
  {
    private readonly RestaurantLibraryContext _context;

    public RestaurantLibraryRepository(RestaurantLibraryContext context)
    {
      _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public IEnumerable<Restaurant> GetRestaurants()
    {
      return _context.Restaurants.ToList<Restaurant>();
    }

    public Restaurant GetRestaurant(Guid restaurantId)
    {
      if(restaurantId == Guid.Empty)
      {
        throw new ArgumentNullException(nameof(restaurantId));
      }

      return _context.Restaurants.FirstOrDefault(f => f.Id == restaurantId);
    }

    public void AddRestaurant(Restaurant restaurant)
    {

    }

    public void UpdateRestaurant(Guid restaurantId, Restaurant restaurant)
    {

    }

    public void DeleteRestaurant(Guid restaurantId)
    {

    }

    
  }

  
}