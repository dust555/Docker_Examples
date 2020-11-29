using System;
using System.ComponentModel.DataAnnotations;

namespace MyShop.Models{
    public class Car{
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public String Manuf { get; set; }
        public String Model { get; set; }
    }
}