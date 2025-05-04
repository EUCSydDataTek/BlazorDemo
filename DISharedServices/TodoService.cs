using DISharedServices.Dto;

namespace DISharedServices
{
    public class TodoService : ITodoService
    {
        private int _count;
        private List<TodoDto> _todos;

        public TodoService()
        {
            _count = 5;
            _todos = new List<TodoDto>() {
                new TodoDto() { Id = 1, Title = "Item1" },
                new TodoDto() { Id = 2, Title = "Item2" },
                new TodoDto() { Id = 3, Title = "Item3" },
                new TodoDto() { Id = 4, Title = "Item4" },
            };
        }

        public List<TodoDto> GetTodos()
        { return _todos; }

        public TodoDto CreateTodo(string name)
        {
            var newTodo = new TodoDto() { Id = _count, Title = name };
            _todos.Add(newTodo);
            _count++;
            return newTodo;
        }

        public void RemoveTodo(int TodoId)
        {
            var todo = _todos.Where(t => t.Id == TodoId).FirstOrDefault();

            if (todo != null)
            {
                _todos.Remove(todo);
            }
        }
    }
}
