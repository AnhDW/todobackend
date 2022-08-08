using todobackend.Model;

namespace todobackend.Service.Todos
{
    public interface ITodosSevice
    {
        List<Todo> GetTodos();
        Boolean AddTodo(Todo todo);
        Boolean UpdateTodo(Todo todo);
        Boolean DelTodo(int id);
    }
}
