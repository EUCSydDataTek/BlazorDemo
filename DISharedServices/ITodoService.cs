using DISharedServices.Dto;

namespace DISharedServices
{
    public interface ITodoService
    {
        TodoDto CreateTodo(string name);
        List<TodoDto> GetTodos();
        void RemoveTodo(int TodoId);
    }
}