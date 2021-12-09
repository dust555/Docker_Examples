using aspnet.dto;
using aspnet.Models;
using aspnet.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace aspnet.Controllers
{
    [ApiController]
    [Route("api/todo")]
    public class TodoController : ControllerBase
    {

        private readonly IRepo _repo;
        private readonly IMapper _map;

        public TodoController(IRepo repo, IMapper map)
        {
            _repo = repo;
            _map = map;
        }

        [HttpGet]
        public ActionResult GetAllTodo(){
            return Ok(_map.Map<IEnumerable<TodoReadDto>>(_repo.GetAllTodo()));
        }

        [HttpGet("{id}", Name="GetTodoById")]
        public ActionResult GetTodoById(int id){
            
            return Ok(_map.Map<TodoReadDto>(_repo.GetTodoById(id)));
        }


        [HttpPost]
        public ActionResult AddTodo(TodoWriteDto t){
            var todo = _map.Map<Todo>(t);

            _repo.AddTodo(todo);
            _repo.SaveChanges();

            return CreatedAtRoute(nameof(GetTodoById), new {Id = todo.Id}, todo);


        }


        [HttpPut("{id}")]
        public ActionResult UpdateTodo(int id, TodoUpdateDto t){
            var existingTodo = _repo.GetTodoById(id);

            if(existingTodo == null){
                return NotFound();
            }

            _map.Map(t, existingTodo);   

            _repo.UpdateTodo(existingTodo);

            _repo.SaveChanges(); 

            return Ok();

        }


        [HttpDelete("{id}")]
        public ActionResult DeleteTodo(int id){
            var existingTodo = _repo.GetTodoById(id);

            if(existingTodo == null){
                return NotFound();
            } 

            _repo.DeleteTodo(existingTodo);
            _repo.SaveChanges();
            return Ok();
        }
        
    }
}