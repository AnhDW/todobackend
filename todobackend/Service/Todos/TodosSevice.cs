using todobackend.Data;
using todobackend.Model;

namespace todobackend.Service.Todos
{
    public class TodosSevice : ITodosSevice
    {
        private readonly TodosDbContext _todosDbContext;
        public TodosSevice(TodosDbContext todosDbContext)
        {
            _todosDbContext = todosDbContext;
        }

        public bool AddTodo(Todo todo)
        {
            throw new NotImplementedException();
        }

        public bool DelTodo(Todo todo)
        {
            throw new NotImplementedException();
        }

        public List<Todo> GetTodos()
        {
            return _todosDbContext.Todos.OrderByDescending(x=>x.Id).ToList(); 
        }

        public bool UpdateTodo(Todo todo)
        {
            throw new NotImplementedException();
        }
    }
}
