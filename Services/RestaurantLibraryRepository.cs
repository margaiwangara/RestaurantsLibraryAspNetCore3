using System;
using System.Collections.Generic;
using AspNetCoreMVCMovie.Entities;
using AspNetCoreMVCMovie.DbContexts;

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
      return _context.Authors.ToList();
    }

    public Restaurant GetRestaurant(Guid restaurantId)
    {

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