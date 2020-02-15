using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreMVCMovie.Models;
using System.Collections.Generic;
using AspNetCoreMVCMovie.Services;
using AspNetCoreMVCMovie.Entities;

namespace AspNetCoreMVCMovie.Controllers.Api
{
  [ApiController]
  [Route("api/restaurants")]
  public class RestaurantsController : ControllerBase
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
    public ActionResult<RestaurantDto> CreateRestaurant(
          [FromBody] RestaurantForCreationDto restaurant)
    {
        var restaurantFromRepo = _mapper.Map<Restaurant>(restaurant);
       _restaurantLibraryRepository.AddRestaurant(restaurantFromRepo);
       _restaurantLibraryRepository.Save();

        var restaurantToReturn = _mapper.Map<RestaurantDto>(restaurantFromRepo);

        return CreatedAtRoute("GetRestaurant", 
              new { restaurantId = restaurantToReturn.Id}, restaurantToReturn);  
    }

    [HttpDelete("{restaurantId}")]
    public ActionResult DeleteRestaurant(Guid restaurantId)
    {
      var restaurantFromRepo = _restaurantLibraryRepository.GetRestaurant(restaurantId);

      // if not exists
      if(restaurantFromRepo == null)
      {
        return NotFound();
      }

      // else delete
      _restaurantLibraryRepository.DeleteRestaurant(restaurantFromRepo);
      _restaurantLibraryRepository.Save();

      return NoContent();
    }
  }
}