using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarMax.Cita.Web.Models.Mappings
{
    public  class SearchCarViewModelMapper
    {
        public static SearchCarViewModel Map(Car car)
        {
            return new SearchCarViewModel
            {
                StockNumber = car.StockNumber,
                Make = car.Make,
                Model = car.Model,
                Year = car.Year
            };
        }
        
    }
}
