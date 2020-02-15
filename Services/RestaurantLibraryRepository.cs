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

    public IEnumerable<Menu> GetMenus(Guid restaurantId)
    {
      if(restaurantId == Guid.Empty)
      {
        throw new ArgumentNullException(nameof(restaurantId));
      }

      return _context.Menus
                      .Where(m => m.RestaurantId == restaurantId)
                      .OrderBy(m => m.Name).ToList();

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

      // initialize defalts
      restaurant.Id = Guid.NewGuid();
      restaurant.DateAdded = DateTime.Now;
      _context.Restaurants.Add(restaurant);
    }

    public void UpdateRestaurant(Restaurant restaurant)
    {
      // no logic
    }

    public void DeleteRestaurant(Restaurant restaurant)
    {
      if(restaurant == null)
      {
        throw new ArgumentNullException(nameof(restaurant));
      }

      _context.Restaurants.Remove(restaurant);

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