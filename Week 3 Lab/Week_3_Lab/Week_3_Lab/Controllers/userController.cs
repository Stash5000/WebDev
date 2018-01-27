using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Week_3_Lab.Data.Entities;
using Week_3_Lab.Data;

namespace Week_3_Lab.Controllers
{
    public class userController : Controller
    {
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(users user) {
            if (user.email.Contains("@") && !user.email.Contains(" "))
            {
                database.addUser(user);
                return RedirectToAction("UserList");
            }
            return RedirectToAction("Create");
        }

        [HttpGet]
        public ActionResult UserList() {
            return View(database.getList);
        }

        [HttpGet]
        public ActionResult details(int id) {
            foreach (users theUser in database.getList) {
                if (id == theUser.id) return View(theUser);
            }
            return RedirectToAction("Create");
        }
    }
}