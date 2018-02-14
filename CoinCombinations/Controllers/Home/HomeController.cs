using Microsoft.AspNetCore.Mvc;
using CoinCombinations.Models;

namespace CoinCombinations.Controllers
{
  public class HomeController: Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}
