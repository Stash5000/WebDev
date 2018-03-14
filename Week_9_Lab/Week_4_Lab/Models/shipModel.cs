using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Week_4_Lab_Joey_Dias.Models
{
    public class shipModel
    {
        
        public int id;
        public int userId;

        [Required]
        [Display(Name = "Size")]
        public int size { get; set; }

        [Display(Name = "Description")]
        public string description { get; set; }

        [Required]
        [Display(Name = "Price")]
        public double price { get; set; }
    }
}