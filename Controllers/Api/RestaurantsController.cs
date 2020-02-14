using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AspNetCoreMVCMovie.Services;
using AspNetCoreMVCMovie.Entities;

namespace AspNetCoreMVCMovie.Controllers.Api
{
  [Route("api/restaurants")]
  public class RestaurantsController: Controller
  {

    private readonly IRestaurantLibraryRepository _restaurantLibraryRepository;

    public RestaurantsController(IRestaurantLibraryRepository restaurantLibraryRepository)
    {
      _restaurantLibraryRepository = restaurantLibraryRepository ?? 
              throw new ArgumentNullException(nameof(restaurantLibraryRepository));
    }

    [HttpGet()]
    public ActionResult<IEnumerable<Restaurant>> GetRestaurants()
    {
      return Ok(_restaurantLibraryRepository.GetRestaurants());
    }
  }
}