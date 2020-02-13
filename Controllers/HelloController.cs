using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVCMovie.Controllers
{
  class HelloController: Controller
  {
    // GET /Hello
    public IActionResult index()
    {
      return View();
    }

    // GET /Hello/Id
    [Route("/Hello/{id}")]
    public string getHello()
    {
      return "This is another hello stuf";
    }
    
  }
}