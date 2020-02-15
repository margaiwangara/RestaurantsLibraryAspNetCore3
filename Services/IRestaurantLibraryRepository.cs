using System;
using System.Collections.Generic;
using AspNetCoreMVCMovie.Entities;

namespace AspNetCoreMVCMovie.Services
{
  public interface IRestaurantLibraryRepository
  {
    // Menu
    IEnumerable<Menu> GetMenus(Guid restaurantId);
    // Menu GetMenu(Guid restaurantId, Guid menuId);
    // void AddMenu(Menu menu);
    // void UpdateMenu(Menu menu);
    // void DeleteMenu(Menu menu);
    // Restaurant
    IEnumerable<Restaurant> GetRestaurants();
    Restaurant GetRestaurant(Guid restaurantId);
    void AddRestaurant(Restaurant restaurant);
    void UpdateRestaurant(Restaurant restaurant);
    void DeleteRestaurant(Restaurant restaurant);

    bool RestaurantExists(Guid restaurantId);
    bool Save();
  }
}