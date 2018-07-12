using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarMax.Cita.Web.Models
{
    public class SearchViewModel
    {
        public List<SearchCarViewModel> Cars { get; set; }

        public SearchViewModel()
        {
            Cars = new List<SearchCarViewModel>();
        }
    }
}
