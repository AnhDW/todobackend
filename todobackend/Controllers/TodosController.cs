using Microsoft.AspNetCore.Mvc;
using todobackend.Model;
using todobackend.Service.Todos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace todobackend.Controllers
{
    [Route("v1/api/todos")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodosSevice _todosSevice;
        public TodosController(ITodosSevice todosSevice)
        {
            _todosSevice = todosSevice;
        }

        // GET: api/<TodosController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_todosSevice.GetTodos());
        }

        // GET api/<TodosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TodosController>
        [HttpPost]
        public IActionResult Post(Todo todo)
        {
            return Ok(_todosSevice.AddTodo(todo));
        }

        // PUT api/<TodosController>/5
        [HttpPut()]
        public IActionResult Put(Todo todo)
        {
            return Ok(_todosSevice.UpdateTodo(todo));
        }

        // DELETE api/<TodosController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_todosSevice.DelTodo(id));
        }
    }
}
