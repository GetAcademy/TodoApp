using TodoApp.Model;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseHttpsRedirection();
app.UseStaticFiles();

var todos = new List<Todo>()
{
    new Todo("Male huset"),
    new Todo("Skifte til vinterdekk"),
    new Todo("Snekre terrasse"),
};

app.MapGet("/todo", () =>
{
    return todos;
});
app.Run();
