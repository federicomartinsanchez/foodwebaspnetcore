using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using odetofood.Data;
using odetofood.Models;

namespace odetofood.Services
{
    public class SqlRestaurantData : IRestaurantData
    {
        private odetofoodDbContext _context;

        public SqlRestaurantData(odetofoodDbContext context)
        {
            _context = context;
        }
        public Restaurant Add(Restaurant restaurant)
        {
            _context.Restaurants.Add(restaurant);
            _context.SaveChanges();
            return restaurant;
        }

        public Restaurant Get(int id)
        {
            return _context.Restaurants.FirstOrDefault(r => r.Id == id);
        }

        public Restaurant Edit(Restaurant restaurant, int id)
        {
            Restaurant edit = _context.Restaurants.FirstOrDefault(r => r.Id == id);

            edit.Name = restaurant.Name;
            edit.Cuisine = restaurant.Cuisine;
            _context.SaveChanges();

            return edit;
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return _context.Restaurants.OrderBy(r => r.Name);
        }
    }
}
