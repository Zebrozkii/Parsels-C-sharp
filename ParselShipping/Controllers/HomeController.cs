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
    public ActionResult Index(int? height, int? width, int? length, int? weight)
    {
      if ((height == null) || (!width.HasValue) || (length == null) || (!weight.HasValue))
      {
        return RedirectToAction("CreateParsel");
        // alert
      }
      else
      {
        Parsel newParsel = new Parsel(height.Value, width.Value, length.Value, weight.Value);
        return View(newParsel);
      }
    }



  }
}
