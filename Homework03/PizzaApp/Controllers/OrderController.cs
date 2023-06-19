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
            List<Order> ordersDb = StaticDb.Orders;

            ViewData["Message"] = $"The number of orders is: {ordersDb.Count}";
            ViewData["Title"] = "Order list";
            ViewData["Date"] = DateTime.Now.ToShortDateString();

            List<OrderDetailsViewModel> orderList = ordersDb.Select(x => x.MapFromOrderToOrderDetailsViewModel()).ToList();

            return View(orderList);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return new EmptyResult();
            }

            Order orderDb = StaticDb.Orders.FirstOrDefault(o => o.Id == id);

            if (orderDb == null)
            {
                return new EmptyResult();
            }

            OrderDetailsViewModel orderDetails = orderDb.MapFromOrderToOrderDetailsViewModel();

            ViewBag.Message = "You are on the order details page";


            return View(orderDetails);
        }
    }
}
