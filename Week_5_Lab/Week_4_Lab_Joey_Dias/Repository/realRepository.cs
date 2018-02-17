using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Week_5_Lab_Joey_Dias.Data.Entities;
using Week_5_Lab_Joey_Dias.Data;

namespace Week_5_Lab_Joey_Dias.Repository
{
    public class realRepository : IRepository
    {
        public enum type { USER, SPACESHIP }
        private Database data;
        public realRepository(Database data) {
            this.data = data;
        }
        public void delete(entity e)
        {
            if (e is User) data.users.Remove(data.users.Find(e.id)); //Find the user and remove it
            else data.ships.Remove(data.ships.Find(e.id)); //Find the ship and remove it
        }

        public void edit(entity e)
        {
            if (e is User)
            {
                User found = data.users.Find(e.id);
                User newU = e as User;
                found.fName = newU.fName;
                found.lName = newU.lName;
                found.email = newU.email;
                found.age = newU.age;
                found.phone = newU.phone;
            }
            else {
                spaceship found = data.ships.Find(e.id);
                spaceship newS = e as spaceship;
                found.description = newS.description;
                found.price = newS.price;
                found.size = newS.size;
            }
            data.SaveChanges();
        }

        public void save(entity e)
        {
            if (e is User)
            {
                data.users.Add(e as User);
            }
            else data.ships.Add(e as spaceship);
            data.SaveChanges();
        }

        public entity find(int id, type toFind)
        {
            if (toFind == type.USER)
            {
                return data.users.Find(id);
            }
            else return data.ships.Find(id);
        }

        public IEnumerable<entity> getAll(type theType, int id = -1)
        {
            if (theType == type.USER)
            {
                List<User> userLST = new List<User>();
                foreach (User u in data.users) {
                    userLST.Add(u);
                }
                return userLST;
            }
            if (id == -1) return null;
            List<spaceship> ships = new List<spaceship>();
            foreach (spaceship s in data.ships) {
                if (s.userId == id) ships.Add(s);
            }
            return ships;
        }
    }
}