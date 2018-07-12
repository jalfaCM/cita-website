using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CarMax.Cita.Web.Models;
using CarMax.Cita.Web.Gateways;
using CarMax.Cita.Web.Models.Mappings;

namespace CarMax.Cita.Web.Controllers
{
    public class SearchController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var model = new SearchViewModel();
            var gateway = new InMemorySearchGateway();
            var cars = gateway.GetCars();

            model.Cars = cars.Select(x => SearchCarViewModelMapper.Map(x)).ToList();
            return View();
        }
    }
}
