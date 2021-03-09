using I_Eat_Spargus.DB;
using I_Eat_Spargus.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace I_Eat_Spargus.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
       

        public HomeController(ILogger<HomeController> logger)
        {
            this.logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.NewsFeed = from item in Operation.DisplayingAllUsers()
                               orderby item.Date descending
                               select item;
            return View();
        }

        
    }
}
