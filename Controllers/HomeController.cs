using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using cd_c_viewModelFun.Models;

namespace cd_c_viewModelFun.Controllers
{
    public class HomeController : Controller
    {
        public List<User> GenerateUsers()
        {
            return new List<User>()
            {
                new User(){ FirstName = "Frankie", LastName = "Valli"}, 
                new User(){ FirstName = "Buddy", LastName = "Holly"}, 
                new User(){ FirstName = "Wilson", LastName = "Phillips"}, 
                new User(){ FirstName = "Duran", LastName = "Duran"}, 
            };
        }
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            string stringModel = "Baboon bottoms are red, Oxyura australis' bill is blue, Hippos spray their feces, and sometimes humans do, too";
        
            return View("Index", stringModel);
        }

        [HttpGet("Numbers")]
        public IActionResult Numbers()
        {
            int[] nums = new int[]
            {
                1, 87, 34, 97, 5, 7, 99
            };
            return View(nums);
        }

        

        [HttpGet("users")]
        public IActionResult Users()
        {
            var users = GenerateUsers();
            return View(users);
        }

        [HttpGet("user")]
        public IActionResult aUser()
        {
            var rando = new Random();
            var users = GenerateUsers();
            var user = users[rando.Next(users.Count)];
            return View("User", user);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
