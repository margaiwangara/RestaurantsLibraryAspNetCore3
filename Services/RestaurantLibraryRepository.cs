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
      if(restaurant == null)
      {
        throw new ArgumentNullException(nameof(restaurant));
      }

      _context.Restaurants.Add(restaurant);
    }

    public void UpdateRestaurant(Guid restaurantId, Restaurant restaurant)
    {

    }

    public void DeleteRestaurant(Guid restaurantId)
    {

    }

    public bool RestaurantExists(Guid restaurantId)
    {
      if(restaurantId == Guid.Empty)
      {
        throw new ArgumentNullException(nameof(restaurantId));
      }

      return _context.Restaurants.Any(r => r.Id == restaurantId);

    }
    public bool Save()
    {
      return (_context.SaveChanges() >= 0);
    }

    
  }

  
}