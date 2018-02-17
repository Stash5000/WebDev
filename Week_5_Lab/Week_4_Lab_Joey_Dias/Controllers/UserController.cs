using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Week_5_Lab_Joey_Dias.Data;
using Week_5_Lab_Joey_Dias.Data.Entities;

namespace Week_5_Lab_Joey_Dias.Controllers
{
    public class UserController : Controller
    {
        static int holdID;
        static Repository.IRepository repo;
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create() {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Models.userModel toCreate) {
            if (ModelState.IsValid)
            {
                User theUser = createUser(toCreate);
                repo.save(theUser);
                return RedirectToAction("Display");
            }
            else return View();
        }
        [HttpGet]
        public ActionResult Display() {
            if(repo == null) repo = new Repository.realRepository(new Database());
            IEnumerable<entity> e = repo.getAll(Repository.realRepository.type.USER);
            return View(modelLST(e));
        }
        [HttpGet]
        public ActionResult Details(int id) {
            entity newUser = repo.find(id, Repository.realRepository.type.USER);
            return View(toModel(newUser as User));
        }
        public ActionResult Delete(int id) {
            repo.delete(repo.find(id, Repository.realRepository.type.USER));
            return RedirectToAction("Display");
        }
        [HttpGet]
        public ActionResult Edit(int id) {
            holdID = id;
            entity toEdit = repo.find(id, Repository.realRepository.type.USER);
            return View(toModel(toEdit as User));
        }
        [HttpPost]
        public ActionResult Edit(Models.userModel edited) {
            if (ModelState.IsValid)
            {
                edited.id = holdID;
                repo.edit(createUser(edited));
                return RedirectToAction("Display");
            }
            else return View();
        }

        public void saveUser(User newUser) {
            Database data = new Database();
            data.users.Add(newUser);
            data.SaveChanges(); //Save changes to database
        }
        public void deleteUser(int id) {
            Database data = new Database();
            data.users.Remove(data.users.Find(id));
            data.SaveChanges(); //Save changes to database
        }
        public void editUser(Models.userModel newUser) {
            Database data = new Database();
            Data.Entities.User found = data.users.Find(holdID);
            copy(found, newUser);
            data.SaveChanges();
        }
        public User createUser(Models.userModel mod) {
            return new Data.Entities.User
            {
                id = mod.id,
                fName = mod.fName,
                lName = mod.lName,
                email = mod.email,
                phone = mod.phone,
                age = mod.age
            };
        }
        public Models.userModel toModel(User theUser) {
            return new Models.userModel {
                id = theUser.id,
                fName = theUser.fName,
                lName = theUser.lName,
                email = theUser.email,
                phone = theUser.phone,
                age = theUser.age
            };
        }
        public List<Models.userModel> modelLST(IEnumerable<entity> users) {
            List<Models.userModel> models = new List<Models.userModel>();
            foreach (entity e in users) {
                models.Add(toModel(e as User));
            }
            return models;
        }
        public IEnumerable<Models.userModel> getAllUsers() {
            List<Models.userModel> userLST = new List<Models.userModel>();
            Database data = new Database();
            foreach (User theUser in data.users) {
                userLST.Add(toModel(theUser));
            }
            return userLST;
        }
        public Models.userModel find(int id) {
            return toModel((new Data.Database()).users.Find(id)); 
        }
        public User findUser(int id) {
            return (new Database()).users.Find(id);
        }
        public void copy(User user, Models.userModel newUser) {
            user.fName = newUser.fName;
            user.lName = newUser.lName;
            user.phone = newUser.phone;
            user.email = newUser.email;
            user.age = newUser.age;
        }
    }
}