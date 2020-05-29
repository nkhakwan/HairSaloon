using Microsoft.AspNetCore.Mvc;

namespace HairSaloon.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}