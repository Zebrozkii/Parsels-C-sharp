using Microsoft.AspNetCore.Mvc;
using ParselShipping.Models;

namespace ParselShipping.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult CreateParsel()
    {
      return View();
    }

    [HttpPost("/display")]
    public ActionResult Index(int height, int width, int length, int weight)
    {
      Parsel newParsel = new Parsel(height, width, length, weight);
      return View(newParsel);
    }



  }
}
