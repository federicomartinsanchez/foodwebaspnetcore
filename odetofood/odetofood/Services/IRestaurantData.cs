using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using odetofood.Models;

namespace odetofood.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant Get(int id);
        Restaurant Add(Restaurant restaurant);
        Restaurant Edit(Restaurant restaurant, int id);
    }
}
