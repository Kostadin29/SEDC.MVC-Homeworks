﻿using Microsoft.AspNetCore.Mvc;
using PizzaApp.Models;
using PizzaApp.Models.Domain;
using PizzaApp.Models.Mappers;
using PizzaApp.Models.ViewModels.UserViewModels;
using System.Diagnostics;

namespace PizzaApp.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

       
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult About()
        {
            return View();
        }


        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult SeeUsers()
        {
            List<User> users = StaticDb.Users;
            List<UserListViewModel> usersListDetails = users.Select(x => x.MapFromUserToListAllUsers()).ToList();
            return View(usersListDetails);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}