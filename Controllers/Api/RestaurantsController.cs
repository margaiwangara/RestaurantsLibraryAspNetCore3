using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AspNetCoreMVCMovie.Services;
using AspNetCoreMVCMovie.Entities;
using AutoMapper;
using AspNetCoreMVCMovie.Models;

namespace AspNetCoreMVCMovie.Controllers.Api
{
  [Route("api/restaurants")]
  public class RestaurantsController: Controller
  {

    private readonly IRestaurantLibraryRepository _restaurantLibraryRepository;
    private readonly IMapper _mapper;
    public RestaurantsController(IRestaurantLibraryRepository restaurantLibraryRepository,
              IMapper mapper)
    {
      _restaurantLibraryRepository = restaurantLibraryRepository ?? 
              throw new ArgumentNullException(nameof(restaurantLibraryRepository));
      _mapper = mapper ?? 
              throw new ArgumentNullException(nameof(mapper));
    }

    [HttpGet()]
    public ActionResult<IEnumerable<Restaurant>> GetRestaurants()
    {
      var restaurantsFromRepo = _restaurantLibraryRepository.GetRestaurants();

      return Ok(_mapper.Map<IEnumerable<RestaurantDto>>(restaurantsFromRepo));
    }

    [HttpGet("{restaurantId}", Name="GetRestaurant")]
    public IActionResult GetRestaurant(Guid restaurantId)
    {
      var restaurantFromRepo = _restaurantLibraryRepository.GetRestaurant(restaurantId);

      // if not found
      if(restaurantFromRepo == null)
      {
        return NotFound();
      }

      return Ok(_mapper.Map<RestaurantDto>(restaurantFromRepo));
    }
    
    [HttpPost]
    public IActionResult CreateRestaurant(RestaurantDto restaurant)
    {
        var restaurantFromRepo = _mapper.Map<Restaurant>(restaurant);
       _restaurantLibraryRepository.AddRestaurant(restaurantFromRepo);
       _restaurantLibraryRepository.Save();

        var restaurantToReturn = _mapper.Map<RestaurantDto>(restaurantFromRepo);

        return CreatedAtRoute("GetRestaurant", 
              new { restaurantId = restaurantToReturn.Id}, restaurantToReturn);  
    }
  }
}