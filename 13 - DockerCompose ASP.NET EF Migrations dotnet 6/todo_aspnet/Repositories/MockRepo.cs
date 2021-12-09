using aspnet.Models;

namespace aspnet.Repositories
{
    public class MockRepo : IRepo
    {
        List<Todo> todolist = new List<Todo>();

        public MockRepo()
        {
            todolist.Add(new Todo(){Id = 1, Title = "Sleep", Urgency="1"});
            todolist.Add(new Todo(){Id = 2, Title = "Eat", Urgency="2"});
            todolist.Add(new Todo(){Id = 3, Title = "Work", Urgency="5"});
            todolist.Add(new Todo(){Id = 4, Title = "Play", Urgency="0"});
        }

        public void AddTodo(Todo t)
        {
            todolist.Add(t);
        }

        public void DeleteTodo(Todo t)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Todo> GetAllTodo(){
            return todolist;
        }

        public Todo GetTodoById(int id){
            Todo _todo = todolist.FirstOrDefault<Todo>(t => t.Id == id);
            return _todo;
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateTodo(Todo t)
        {
            throw new NotImplementedException();
        }
    }
}