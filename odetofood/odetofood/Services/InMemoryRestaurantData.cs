﻿using odetofood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace odetofood.Services
{
    public class  InMemoryRestaurantData : IRestaurantData
    {
        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant{Id=1, Name = "Pizza's Palace" },
                new Restaurant{Id=2, Name = "Burguer's Palace" },
                new Restaurant{Id=3, Name = "Taco's Palace" },
            };
        }
    public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(r => r.Name);
        }
        List<Restaurant> _restaurants;
    }
}
