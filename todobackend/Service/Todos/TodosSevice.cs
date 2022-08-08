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
            _todosDbContext.Todos.Add(todo);
            _todosDbContext.SaveChanges();
            return true;
        }

        public bool DelTodo(int id)
        {
            Todo todo = _todosDbContext.Todos.Find(id);
            _todosDbContext.Todos.Remove(todo);
            _todosDbContext.SaveChanges();
            return true;
        }

        public List<Todo> GetTodos()
        {
            return _todosDbContext.Todos.OrderByDescending(x=>x.Id).ToList(); 
        }

        public bool UpdateTodo(Todo todo)
        {
            _todosDbContext.Todos.Update(todo);
            _todosDbContext.SaveChanges();
            return true;
        }
    }
}
