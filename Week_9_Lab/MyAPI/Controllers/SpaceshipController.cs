using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Week_4_Lab_Joey_Dias;
using System.Data.Entity;

namespace MyAPI.Controllers
{
    public class SpaceshipController : ApiController
    {
        private Week_4_Lab_Joey_Dias.Data.Database data;
        public SpaceshipController() {
            data = new Week_4_Lab_Joey_Dias.Data.Database();
        }

        [HttpGet]
        public IEnumerable<Week_4_Lab_Joey_Dias.Data.Entities.spaceship> GetAllShips() {
            return data.ships.ToList();
        }

        [Route("(id)")]
        [HttpGet]
        public IHttpActionResult GetShip(int id) {
            var s = data.ships.Find(id);
            if (s == null) return NotFound();
            return Ok(s);
        }
    }
}
