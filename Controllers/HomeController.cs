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
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            string[] message = new string[]
            {
                "Baboon bottoms are red", 
                "Oxyura australis's bill is blue", 
                "Hippos spray their feces", 
                "and sometimes humans do, too"
            };
        
            return View(message);
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

        public class UserUser
        {
            public string FirstName {get;set;}
            public string LastName {get;set;}
        }

        [HttpGet("users")]
        public IActionResult Users()
        {
            List<string> users = new List<string>
            {
                "La Croix",
                "Waterloo", 
                "Aha",
                "Bubly"
            };
            return View(users);
        }

        [HttpGet("user")]
        public IActionResult Auser()
        {
            UserUser thisuser = new UserUser();
            {
                thisuser.FirstName = "Moose";
                thisuser.LastName = "Phillips";
            }
            return View(thisuser);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
