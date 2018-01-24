using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using odetofood.Models;
using odetofood.Services;
using odetofood.ViewModels;

namespace odetofood.Controllers
{
    public class HomeController : Controller
    {
        private IRestaurantData _restaurantData;

        public HomeController(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }

        public IActionResult Index()
        {
            var model = _restaurantData.GetAll();
            return View(model);
        }

        public IActionResult Details(int id)
        {
            var model = _restaurantData.Get(id);
            if (model == null)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(RestaurantEditModel model)
        {
            if (ModelState.IsValid)
            {
                var newRestaurant = new Restaurant();
                newRestaurant.Name = model.Name;
                newRestaurant.Cuisine = model.Cuisine;
           
                newRestaurant = _restaurantData.Add(newRestaurant);

                return RedirectToAction(nameof(Details), new { id = newRestaurant.Id });
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var oldRestaurant = _restaurantData.Get(id);
            return View(oldRestaurant);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(RestaurantEditModel model, int id)
        {
            
            if (ModelState.IsValid)
            {
                var editRestaurant = new Restaurant();
                editRestaurant.Name = model.Name;
                editRestaurant.Cuisine = model.Cuisine;

                editRestaurant = _restaurantData.Edit(editRestaurant,id);

                return RedirectToAction(nameof(Details), new { id = editRestaurant.Id });
            }
            else
            {
                return View();
            }
        }
    }
}