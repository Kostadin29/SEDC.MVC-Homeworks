using Microsoft.AspNetCore.Mvc;
using PizzaApp_Prekucuvanje.Models;

namespace PizzaApp_Prekucuvanje.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza> pizzas = StaticDb.Pizzas;
            return View(pizzas);
        }
    }
}
