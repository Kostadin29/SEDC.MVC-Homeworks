using Microsoft.AspNetCore.Mvc;
using BurgerApp.Services.Interfaces;

namespace BurgerApp.Controllers
{
    public class BurgerController : Controller
    {
        private IBurgerService _burgerService;

        public BurgerController(IBurgerService _burgerService)
        {
            this._burgerService = _burgerService;
        }

        public async Task<IActionResult> IndexAsync()
        {
            return View(await _burgerService.GetBurgersForCards());
        }
    }
}
