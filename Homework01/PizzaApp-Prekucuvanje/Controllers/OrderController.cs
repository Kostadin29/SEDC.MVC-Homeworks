using Microsoft.AspNetCore.Mvc;
using PizzaApp_Prekucuvanje.Models;

namespace PizzaApp_Prekucuvanje.Controllers
{
    // 1. Create new Controller for managing Orders (name it accordingly)
    public class OrderController : Controller
    {
        public static List<Order> Orders = new List<Order>
        {

            new Order { Id = 1, Name = "John Doe", Price = 499 },
            new Order { Id = 2, Name = "Mia Smith", Price = 349 },
            new Order { Id = 3, Name = "Emilly Johnson", Price = 299 }

        };


        // 2. Add Index action that returns a view with a simple html that
        // says “List of orders”. It should be accessed through custom
        // route http://localhost:[port]/ListOrders
        [Route("ListOrders")]
        public IActionResult Index()
        {
            List<Order> orders = Orders.ToList();
            return View(orders);
        }

        public IActionResult Empty()
        {
            return new EmptyResult();
        }

        // 3. Add Details action with optional parameter id. If id is null it should return empty action result,
        // else it should return a view with simple html. It should be accessed through
        // route http://localhost/[Controller Name]/Details/{id?}
        [Route("Order/Details/{id?}")]
        public IActionResult Details(int? id)
        {

            Order order = Orders.FirstOrDefault(o => o.Id == id);


            if (id == null)
            {
                return Empty();
            }

            if (order == null)
            {
                return NotFound();
            }

            return View(order);

        }

        // 4. Add an action that returns Json
        // (create an example model, class by your choice),
        // it should be accessed by http://localhost/[Controller Name]/JsonData.
        [Route("Order/JsonData")]
        public IActionResult ReturnJson()
        {
            Person person = new Person()
            {
                Id = 1,
                Name = "Koko"
            };

            return new JsonResult(person);
        }

        // 5. Add an action that redirects to Action Index in Home Controller.
        public IActionResult Redirect()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
