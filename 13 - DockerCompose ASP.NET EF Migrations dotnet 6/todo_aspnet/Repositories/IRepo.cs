using aspnet.Models;

namespace aspnet.Repositories
{
    public interface IRepo
    {
         IEnumerable<Todo> GetAllTodo();
         Todo GetTodoById(int id);

         void AddTodo(Todo t);

         void UpdateTodo(Todo t);

         void DeleteTodo(Todo t);

         void SaveChanges();
    }
}