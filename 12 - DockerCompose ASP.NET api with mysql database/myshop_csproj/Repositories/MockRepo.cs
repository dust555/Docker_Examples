using System.Collections.Generic;
using MyShop.Models;

namespace MyShop.Repositories{
    public class MockRepo:IRepo{
        public void CreateCar(Car car)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCar(Car c)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Car> GetAllCars(){
            var CarList = new List<Car>();
            CarList.Add(new Car(){Id=1,Manuf="Opel",Model="Zafira"});
            CarList.Add(new Car(){Id=2,Manuf="Ford",Model="Fiesta"});
            CarList.Add(new Car(){Id=3,Manuf="Volvo",Model="V8"});
            return CarList;
        } 


        public Car GetCarById(int id){
            var car = new Car(){Id=1,Manuf="Opel",Model="Zafira"};
            return car;
        }

        public void SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCar(Car car)
        {
            throw new System.NotImplementedException();
        }
    }
}