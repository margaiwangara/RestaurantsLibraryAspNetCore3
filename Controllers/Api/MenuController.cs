using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreMVCMovie.Services;

namespace AspNetCoreMVCMovie.Controllers.Api
{
  [ApiController]
  [Route("api/restaurants/{restaurantId}/menus")]
  public class MenuController : ControllerBase
  {
    private readonly IRestaurantLibraryRepository _restaurantLibraryRepository;
    private readonly IMapper _mapper;

    public MenuController(IRestaurantLibraryRepository restaurantLibraryRespository, 
          IMapper mapper)
    {
      _restaurantLibraryRepository = restaurantLibraryRespository ?? 
              throw new ArgumentNullException(nameof(restaurantLibraryRespository));
      _mapper = mapper ?? 
              throw new ArgumentNullException(nameof(mapper));
    }
    
  } 
}