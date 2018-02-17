using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Week_5_Lab_Joey_Dias.Data.Entities
{
    public class User : entity
    {
        public string fName { get; set; }
        public string lName { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public int age { get; set; }
    }
}