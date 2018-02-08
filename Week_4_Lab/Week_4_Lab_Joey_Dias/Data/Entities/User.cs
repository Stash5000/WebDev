using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Week_4_Lab_Joey_Dias.Data.Entities
{
    public class User
    {
        [Key]
        public int id { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public int age { get; set; }
    }
}