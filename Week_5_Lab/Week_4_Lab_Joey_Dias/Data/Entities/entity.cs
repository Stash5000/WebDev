using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Week_5_Lab_Joey_Dias.Data.Entities
{
    public abstract class entity
    {
        [Key]
        public int id { get; set; }
    }
}