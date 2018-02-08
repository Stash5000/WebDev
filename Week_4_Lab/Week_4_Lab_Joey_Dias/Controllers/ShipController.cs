using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Week_4_Lab_Joey_Dias;
using Week_4_Lab_Joey_Dias.Models;
using Week_4_Lab_Joey_Dias.Data;

namespace Week_4_Lab_Joey_Dias.Controllers
{
    public class ShipController : Controller
    {
        // GET: Ship
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Display(int id) {
            ViewBag.id = id;
            Database data = new Database();
            List<shipModel> thisUserShips = new List<shipModel>();
            foreach (Data.Entities.spaceship ship in data.ships) {
                if (ship.userId == id) thisUserShips.Add(toModel(ship));
            }
            return View(thisUserShips);
        }
        [HttpGet]
        public ActionResult Create(int id) {
            TempData["ID"] = id;
            return View();
        }
        [HttpPost]
        public ActionResult Create(shipModel ship) {
            if (ModelState.IsValid) {
                ship.userId = Convert.ToInt32(TempData["ID"]);
                addShip(ship);
                return RedirectToAction("Display", new { id = ship.userId });
            }
            else return View();
        }

        public void addShip(shipModel ship) {
            Data.Entities.spaceship realShip = toShip(ship);
            Database data = new Database();
            data.ships.Add(realShip);
            data.SaveChanges();
        }

        public shipModel toModel(Data.Entities.spaceship ship) {
            return new shipModel
            {
                id = ship.id,
                userId = ship.userId,
                size = ship.size,
                description = ship.description,
                price = ship.price
            };
        }

        public Data.Entities.spaceship toShip(shipModel model) {
            return new Data.Entities.spaceship {
                id = model.id,
                userId = model.userId,
                size = model.size,
                description = model.description,
                price = model.price
            };
        }
    } 
}