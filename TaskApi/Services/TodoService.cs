using TaskApi.Models;

namespace TaskApi.Services
{
    public class TodoService
    {
        //Get Todos

        public List<Todo> AllTodos()
        {
            var todos = new List<Todo>();

            var todo1 = new Todo()
            {
                Id = 1,
                Title = "water the plans",
                Description = "water all the plants quickly",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(1),
                Status = TodoStatus.New

            };
            todos.Add(todo1);

            var todo2 = new Todo()
            {
                Id = 2,
                Title = "Get vegitables",
                Description = "Get vegitables quickly",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(1),
                Status = TodoStatus.New
            };
            todos.Add(todo2);

            var todo3 = new Todo()
            {
                Id = 3,
                Title = "Get some text books",
                Description = "text books quickly",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(1),
                Status = TodoStatus.New
            };

            todos.Add(todo3);
            return todos;
        }
    }
}
