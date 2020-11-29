using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CarApi.Controllers{


    [ApiController]
    [Route("api/cars")]
    public class CarController:ControllerBase{
        [HttpGet]
        public ActionResult <Car> GetAllCars(){
            var CarList = new List<Car>();
            CarList.Add(new Car(){Id=1, Manufacturer="Ford", Model="Fiesta"});
            CarList.Add(new Car(){Id=1, Manufacturer="Fiat", Model="500"});
            CarList.Add(new Car(){Id=1, Manufacturer="Volvo", Model="V40"});

            return Ok(CarList);
        }
    }
}