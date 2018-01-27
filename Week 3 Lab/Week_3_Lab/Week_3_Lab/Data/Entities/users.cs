using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Week_3_Lab.Data.Entities
{
    public class users
    {
        public int id { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string firstName { get; set; }
        [Display(Name = "Middle Name")]
        public string middleName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string lastName { get; set; }
        [Required]
        [Display(Name = "Email")]
        public string email { get; set; }
        [Required]
        [Display(Name = "Years In School")]
        public int yIS { get; set; }
        [Required]
        [Display(Name = "Description")]
        public string description { get; set; }
    }
}