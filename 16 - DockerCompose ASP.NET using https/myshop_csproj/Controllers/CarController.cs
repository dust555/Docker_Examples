using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyShop.dtos;
using MyShop.Models;
using MyShop.Repositories;

namespace MyShop.Controllers{

    [Route("api/cars")]
    [ApiController]
    public class CarController:ControllerBase{
        private readonly IRepo _repo;
        private readonly IMapper _mapper;

        public CarController(IRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
            
        }


        [HttpGet]
        public ActionResult <IEnumerable<CarReadDTO>> GetAllCars(){
           
            return Ok(_mapper.Map<IEnumerable<CarReadDTO>>(_repo.GetAllCars()));
        }

        [HttpGet("{id}",Name="GetCarById")]
        public ActionResult <CarReadDTO> GetCarById(int id){
            
            return Ok(_mapper.Map<CarReadDTO>(_repo.GetCarById(id)));
        }

        [HttpPost]
        public ActionResult <Car> CreateCar(CarWriteDTO cardto){
            var car = _mapper.Map<Car>(cardto);

            _repo.CreateCar(car);
            _repo.SaveChanges();
            return CreatedAtRoute(nameof(GetCarById), new {Id = car.Id}, car);
        }    

        [HttpPut("{id}")]
        public ActionResult UpdateCar(int id, CarUpdateDTO cardto){
            var carfromrepo = _repo.GetCarById(id);
            if(carfromrepo == null){
                return NotFound();
            }

            _mapper.Map(cardto, carfromrepo);
            _repo.UpdateCar(carfromrepo);
            _repo.SaveChanges();
            return NoContent();

        }

        [HttpDelete("{id}")]
        public ActionResult DeleteCar(int id){
            var carfromrepo = _repo.GetCarById(id);
            if(carfromrepo == null){
                return NotFound();
            }

            _repo.DeleteCar(carfromrepo);
            _repo.SaveChanges();
            return NoContent();
        }
    }

}