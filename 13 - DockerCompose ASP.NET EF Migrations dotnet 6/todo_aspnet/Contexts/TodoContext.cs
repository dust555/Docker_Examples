using aspnet.Models;
using Microsoft.EntityFrameworkCore;

namespace aspnet.Contexts
{
    public class TodoContext:DbContext
    {

        public TodoContext(DbContextOptions<TodoContext> opt):base(opt)
        {
            
        }

        public DbSet<Todo> Todos {get;set;}
        
    }
}