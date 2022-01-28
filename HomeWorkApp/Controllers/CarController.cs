using HomeWorkApp.DAL;
using HomeWorkApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWorkApp.Controllers
{
    public class CarController: Controller
    {
        private readonly FirstDbContext firstdb;

        public CarController(FirstDbContext _firstdb)
        {
            firstdb = _firstdb;
        }

        public IActionResult Index()
        {
            
            return View(firstdb.Cars);
        }

        public IActionResult Info(int id)
        {
            Car car = firstdb.Cars.FirstOrDefault(x => x.Id == id);
            if(car== null)
            {
                TempData["error"] = "Car doesnt exit.";

            }
            return View(car);

        }
    }
}
