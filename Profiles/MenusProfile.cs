using AspNetCoreMVCMovie.Entities;
using AspNetCoreMVCMovie.Models;
using AutoMapper;

namespace AspNetCoreMVCMovie.Profiles
{
  public class MenusProfile : Profile
  {
    public MenusProfile()
    {
      CreateMap<Menu, MenuDto>();
    }
  }
}