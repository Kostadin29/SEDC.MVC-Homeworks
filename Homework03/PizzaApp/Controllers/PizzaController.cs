using Microsoft.AspNetCore.Mvc;
using PizzaApp.Models.Domain;
using PizzaApp.Models.Mappers;
using PizzaApp.Models.ViewModels.PizzaViewModels;

namespace PizzaApp.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza> pizzas = StaticDb.Pizzas;
            List<PizzaViewModel> pizzaList = pizzas.Select(x => x.MapFromPizzaToPizzaViewModel()).ToList();
            return View(pizzaList);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return new EmptyResult();
            }

            Pizza pizzaDb = StaticDb.Pizzas.FirstOrDefault(x => x.Id == id);

            if (pizzaDb == null)
            {
                return new EmptyResult();
            }

            PizzaViewModel pizzaDetails = pizzaDb.MapFromPizzaToPizzaViewModel();

            return View(pizzaDetails);
        }


    }
}
