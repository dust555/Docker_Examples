using Microsoft.EntityFrameworkCore;
using MyShop.Models;

namespace MyShop.Services{
    public class MyShopDbContext:DbContext{
        
        public MyShopDbContext(DbContextOptions<MyShopDbContext> options):base(options){}

        public DbSet<Car> Cars {get; set;}

    }
}