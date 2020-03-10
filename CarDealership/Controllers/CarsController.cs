using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CarDealership.Models;

namespace CarDealership.Controllers
{
  public class CarsController : Controller
  {
  

    [HttpGet("/cars")]
    public ActionResult Index()
    {
      List<Car> allCars = Car.GetAll();
      return View(allCars);
    }

    [HttpPost("/cars")]
    public ActionResult Create(string makeModel, string message, int price, int miles)
    {
      Car car = new Car(makeModel, message, price, miles);
      
      return RedirectToAction("Index", "Home");
    }

    [HttpGet("/cars/new")]
    public ActionResult CreateForm()
    {
      return View();
    }




  }
}