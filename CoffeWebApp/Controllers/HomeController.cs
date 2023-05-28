using System.Linq;
using CoffeWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeWebApp.Controllers
{
    public class HomeController : Controller
    {
        CoffeMachineContext db;
        public HomeController(CoffeMachineContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.CoffeeMachines.ToList());
        }
        
        [HttpGet]
        public IActionResult Buy(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            ViewBag.CoffeMachineId = id;
            return View();
        }
        [HttpPost]
        public string Buy(Order order)
        {
            db.Orders.Add(order);
            // сохраняем в бд все изменения
            db.SaveChanges();
            return "Спасибо, " + order.SellerName + ", за покупку!";
        }
        public IActionResult Order()
        {
            return View(db.CoffeeMachines.ToList());
        }

        [HttpPost]
        public IActionResult Cancel()
        {
            return RedirectToAction("Order");
        }
    }
}