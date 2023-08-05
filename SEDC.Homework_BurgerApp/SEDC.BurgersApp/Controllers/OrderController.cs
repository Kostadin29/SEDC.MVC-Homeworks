using BurgerApp.Services.Interfaces;
using BurgerApp.ViewModels.OrderViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BurgerApp.Controllers
{
    public class OrderController : Controller
    {
        private IOrderService _orderService;
        private IBurgerService _burgerService;
        private ILocationService _locationService;

        public OrderController(IOrderService orderService, IBurgerService burgerService, ILocationService locationService)
        {
            this._orderService = orderService;
            this._burgerService = burgerService;
            this._locationService = locationService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _orderService.GetOrdersForCards());
        }

        public async Task<IActionResult> Delete(int id)
        {
            return View(await _orderService.DeleteOrderById(id));
        }

        public async Task<IActionResult> Create()
        {
            OrderViewModel orderViewModel = new OrderViewModel();
            ViewBag.Burgers = await _burgerService.GetBurgersForDropdown();
            ViewBag.Locations = await _locationService.GetLocationsForDropdown();

            return View(orderViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(OrderViewModel orderViewModel)
        {
            await _orderService.CreateOrder(orderViewModel);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int id)
        {
            OrderViewModel orderViewModel = await _orderService.GetOrdersForEditing(id);
            ViewBag.Burgers = await _burgerService.GetBurgersForDropdown();
            ViewBag.Locations = await _locationService.GetLocationsForDropdown();

            return View(orderViewModel);
        }

        [HttpPost] 
        public async Task<IActionResult>Edit(OrderViewModel orderViewModel)
        {
            await _orderService.EditOrder(orderViewModel);

            return RedirectToAction("Index");
        }
    }
}
