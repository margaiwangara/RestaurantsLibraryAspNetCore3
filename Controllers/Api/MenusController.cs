using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreMVCMovie.Services;
using System.Collections.Generic;
using AspNetCoreMVCMovie.Models;

namespace AspNetCoreMVCMovie.Controllers.Api
{
  [ApiController]
  [Route("api/restaurants/{restaurantId}/menus")]
  public class MenusController : ControllerBase
  {
    private readonly IRestaurantLibraryRepository _restaurantLibraryRepository;
    private readonly IMapper _mapper;

    public MenusController(IRestaurantLibraryRepository restaurantLibraryRespository, 
          IMapper mapper)
    {
      _restaurantLibraryRepository = restaurantLibraryRespository ?? 
              throw new ArgumentNullException(nameof(restaurantLibraryRespository));
      _mapper = mapper ?? 
              throw new ArgumentNullException(nameof(mapper));
    }

    public ActionResult<IEnumerable<MenuDto>> GetMenusForRestaurant(Guid restaurantId)
    {
      if(!_restaurantLibraryRepository.RestaurantExists(restaurantId))
      {
        return NotFound();
      }

      var menusFromRepo = _restaurantLibraryRepository.GetMenus(restaurantId);
      
      return Ok(_mapper.Map<IEnumerable<MenuDto>>(menusFromRepo));
    }
    
  } 
}