using System;
using System.ComponentModel.DataAnnotations;

namespace MyShop.dtos{
    public class CarUpdateDTO{
        //public int Id { get; set; }
        [Required]
        public String Manuf { get; set; }
        public String Model { get; set; }
    }
}