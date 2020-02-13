using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVCMovie.Controllers.Api
{
  [Route("api/restaurants")]
  public class RestaurantsController: Controller
  {
    public string index()
    {
      return "This is a test for the api";
    }
  }
}