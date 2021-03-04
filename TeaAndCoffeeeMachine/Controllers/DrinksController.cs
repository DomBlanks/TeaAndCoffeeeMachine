using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TeaAndCoffeeeMachine.Controllers
{
    [Route("[controller]")]
    public class DrinksController : Controller
    {
        // GET: /<controller>/
        [Route("[action]")]
        public IActionResult LemonTea()
        {
            return View();
        }
        [Route("[action]")]
        public IActionResult Coffee()
        {
            return View();
        }

        [Route("[action]")]
        public IActionResult Chocolate()
        {
            return View();
        }

    }
}
