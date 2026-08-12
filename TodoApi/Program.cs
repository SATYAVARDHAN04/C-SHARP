var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

var todos = new List<Todo>
{
    new Todo
    {
        Id = 1,
        Title = "Learn Minimal APIs",
        IsCompleted = false
    },
    new Todo
    {
        Id = 2,
        Title = "Build a To-Do List",
        IsCompleted = false
    }
};

app.MapGet("/todos", () =>
{
    return Results.Ok(todos);
});

app.MapGet("/todos/{id}", (int id) =>
{
    var todo = todos.FirstOrDefault(t => t.Id == id);

    if (todo == null)
    {
        return Results.NotFound();
    }

    return Results.Ok(todo);
});

app.MapPost("/todos", (Todo todo) =>
{
    todo.Id = todos.Count + 1;

    todos.Add(todo);

    return Results.Created($"/todos/{todo.Id}", todo);
});

app.MapPut("/todos/{id}", (int id, Todo updatedTodo) =>
{
    var todo = todos.FirstOrDefault(t => t.Id == id);

    if (todo == null)
    {
        return Results.NotFound();
    }

    todo.Title = updatedTodo.Title;
    todo.IsCompleted = updatedTodo.IsCompleted;

    return Results.Ok(todo);
});

app.MapDelete("/todos/{id}", (int id) =>
{
    var todo = todos.FirstOrDefault(t => t.Id == id);

    if (todo == null)
    {
        return Results.NotFound();
    }

    todos.Remove(todo);

    return Results.NoContent();
});

app.Run();