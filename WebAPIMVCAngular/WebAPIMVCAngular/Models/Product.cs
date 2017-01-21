using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebAPIMVCAngular.Models
{
    public class Product
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Price { get; set; }

    }
}