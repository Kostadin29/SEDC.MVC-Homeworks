using Microsoft.AspNetCore.Mvc;
using PizzaApp.Models.Domain;
using PizzaApp.Models.Mappers;
using PizzaApp.Models.ViewModels.OrderViewModels;


namespace PizzaApp.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int? id)
        {
            if(id == null)
            {
               return RedirectToAction("Error", "Home");
            }

            Order orderDb = StaticDb.Orders.FirstOrDefault(o => o.Id == id);

            if(orderDb == null)
            {
                return RedirectToAction("Error", "Home");
            }

            OrderListViewModel orderDetails = orderDb.MapFromOrderToOrderListViewModel();
            return View(orderDetails);
        }
    }
}
