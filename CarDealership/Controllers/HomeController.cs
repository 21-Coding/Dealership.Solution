using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CarDealership.Models;

namespace CarDealership.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet ("/")]
    public ActionResult Index()
    {
      List<Car> allCars = Car.GetAll(); 
      return View(allCars);
    }
  }
}