using TodoApp.Model;

namespace TodoApp
{
    public class TodoService
    {
        public static List<Todo> GetAll()
        {
            var todos = new List<Todo>()
            {
                new Todo("Male huset"),
                new Todo("Skifte til vinterdekk"),
                new Todo("Snekre terrasse"),
            };
            return todos;
        }
    }
}
