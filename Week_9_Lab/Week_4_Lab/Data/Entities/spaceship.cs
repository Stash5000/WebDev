using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Week_4_Lab_Joey_Dias.Data.Entities
{
    public class spaceship
    {
        [Key]
        public int id { get; set; }
        public int userId { get; set; }
        public int size { get; set; }
        public string description { get; set; }
        public double price { get; set; }
    }
}