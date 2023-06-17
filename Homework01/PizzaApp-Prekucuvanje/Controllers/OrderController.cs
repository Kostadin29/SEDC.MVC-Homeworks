using Microsoft.AspNetCore.Mvc;
using PizzaApp_Prekucuvanje.Models;

namespace PizzaApp_Prekucuvanje.Controllers
{
    // 1. Create new Controller for managing Orders (name it accordingly)
    public class OrderController : Controller
    {

        // 2. Add Index action that returns a view with a simple html that
        // says “List of orders”. It should be accessed through custom
        // route http://localhost:[port]/ListOrders
        [Route("ListOrders")]
        public IActionResult Index()
        {
            List<Order> orders = StaticDb.Orders.ToList();
            return View(orders);
        }

        public IActionResult Empty()
        {
            return new EmptyResult();
        }

        // 3. Add Details action with optional parameter id. If id is null it should return empty action result,
        // else it should return a view with simple html. It should be accessed through
        // route http://localhost/[Controller Name]/Details/{id?}
        public IActionResult Details(int? id)
        {

            Order order = StaticDb.Orders.FirstOrDefault(o => o.Id == id);


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

        public IActionResult JsonData()
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
