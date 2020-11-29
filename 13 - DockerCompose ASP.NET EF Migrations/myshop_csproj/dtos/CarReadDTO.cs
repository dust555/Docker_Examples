using System;
using System.ComponentModel.DataAnnotations;

namespace MyShop.dtos{
    public class CarReadDTO{
        public int Id { get; set; }
        public String Manuf { get; set; }
        //public String Model { get; set; }
    }
}