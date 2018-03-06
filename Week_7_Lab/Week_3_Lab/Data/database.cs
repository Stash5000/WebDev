using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Week_7_Lab.Data.Entities;

namespace Week_7_Lab.Data
{
    public static class database
    {
        private static List<users> list = new List<users>();
        public static int id = 0;
        public static void addUser(users user) {
            user.id = id++;
            list.Add(user);
        }
        public static List<users> getList {
            get {
                return list;
            }
        }
    }
}