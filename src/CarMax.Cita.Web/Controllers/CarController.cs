using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CarMax.Cita.Web.Models;

namespace CarMax.Cita.Web.Controllers
{
    public class CarController : Controller
    {
        [Route("cars")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("cars/{stockNumber}")]
        public IActionResult CarPage(int stockNumber) {
            Console.Write(stockNumber);
            return View();
        }

    
    }
}

