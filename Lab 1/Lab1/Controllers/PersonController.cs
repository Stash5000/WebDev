using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab1.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            Models.Person.title = "You are a person, I am a person.";
            Models.Person.message = "Get the picture?";
            ViewBag.body = "This is for the first lab of the Web design class.  Here you go.";
            return View();
        }
    }
}