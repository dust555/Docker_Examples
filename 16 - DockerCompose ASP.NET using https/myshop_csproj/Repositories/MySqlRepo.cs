using System.Collections.Generic;
using System.Linq;
using MyShop.Models;
using MyShop.Services;

namespace MyShop.Repositories{
    public class MySqlRepo:IRepo{
        private readonly MyShopDbContext _context;

        public MySqlRepo(MyShopDbContext context)
        {
            _context = context;
        }

        public void CreateCar(Car car)
        {
            _context.Cars.Add(car);
        }

        public void DeleteCar(Car c)
        {
            _context.Cars.Remove(c);
        }

        public IEnumerable<Car> GetAllCars(){
            return _context.Cars.ToList();
        } 


        public Car GetCarById(int id){
            return _context.Cars.FirstOrDefault(p => p.Id == id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void UpdateCar(Car car)
        {
            //
        }
    }
}