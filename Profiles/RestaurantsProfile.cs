using AspNetCoreMVCMovie.Entities;
using AspNetCoreMVCMovie.Models;
using AutoMapper;

namespace AspNetCoreMVCMovie.Profiles
{
  public class RestaurantsProfile : Profile
  {
    public RestaurantsProfile()
    {
      CreateMap<Restaurant, RestaurantDto>();
      CreateMap<RestaurantForCreationDto, Restaurant>();
    }
  }
}