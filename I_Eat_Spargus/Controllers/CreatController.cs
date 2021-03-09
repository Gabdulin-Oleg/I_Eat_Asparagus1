using I_Eat_Spargus.DB;
using I_Eat_Spargus.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace I_Eat_Spargus.Controllers
{
    public class CreatController : Controller
    {
        public IActionResult Registration ()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registration(string firstName, string  lastname,string gmail)
        {
            User user = new User()
            {
                FirstName = firstName,
                LastName = lastname,
                Gmail = gmail,
                NumberamountEaten = 0,
                Date = DateTime.Now
            };
            Operation.Creat(user);            
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string gmail)
        {
            
            if (Operation.Read(gmail) != null)
            {
                var data = DateTime.Now;
                User user = Operation.Read(gmail);
                user.Date = data;
                user.NumberamountEaten++;
                Operation.UpDate(user);
            }
            return View();
        }

    }
}
