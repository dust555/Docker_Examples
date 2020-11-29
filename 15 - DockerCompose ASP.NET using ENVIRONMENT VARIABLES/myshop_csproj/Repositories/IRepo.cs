using System.Collections.Generic;
using MyShop.Models;

namespace MyShop.Repositories{
    public interface IRepo{
        IEnumerable<Car> GetAllCars(); 
        Car GetCarById(int id);

        void CreateCar(Car car);

        void UpdateCar(Car car);
        void DeleteCar(Car c);

        void SaveChanges();


    }
}