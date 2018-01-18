using odetofood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace odetofood.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Restaurant> Restaurants { get; set; }

        //No voy a usar esta clase, pero su utilidad es sacar fuentes de datos de diferentes origenes o servicios
        public string MessageOfTheDay { get; set; }
    }
}
