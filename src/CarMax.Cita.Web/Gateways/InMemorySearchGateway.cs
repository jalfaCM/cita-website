using CarMax.Cita.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarMax.Cita.Web.Gateways
{
    public class InMemorySearchGateway
    {
        public IEnumerable<Car> GetCars()
        {
            return new List<Car>
            {
                new Car{StockNumber="123", Make="Honda", Model="Civic", Year = 1995},
                new Car{StockNumber="1245", Make="Honda", Model="NSX", Year = 2000}
            };
        }
    }
}
