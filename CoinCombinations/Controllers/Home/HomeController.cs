using Microsoft.AspNetCore.Mvc;
using CoinCombinations.Models;
using System.Collections.Generic;

namespace CoinCombinations.Controllers
{
  public class HomeController: Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/")]
    public ActionResult CoinResult()
    {
      CoinCombination inputtedNumber = new CoinCombination(Request.Form["enter-number"]);
      inputtedNumber.ReturnCoinTypes();
      List<double> myCoinCount = inputtedNumber.GetCoinCount();
      return View("Index", myCoinCount);
    }

  }
}
