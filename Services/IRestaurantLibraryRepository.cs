using System;
using System.Collections.Generic;
using AspNetCoreMVCMovie.Entities;

namespace AspNetCoreMVCMovie.Services
{
  public interface IRestaurantLibraryRepository
  {
    // CRUD Interfaces for restaurant model
    IEnumerable<Restaurant> GetRestaurants();
    Restaurant GetRestaurant(Guid restaurantId);
    void AddRestaurant(Restaurant restaurant);
    void UpdateRestaurant(Restaurant restaurant);
    void DeleteRestaurant(Restaurant restaurant);

    bool RestaurantExists(Guid restaurantId);
    bool Save();
  }
}