using THIRD_PROJECT.DTO;
using THIRD_PROJECT.Models;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();


// Temporary in-memory database
List<Book> books = new();

int nextId = 1;


// GET ALL BOOKS
app.MapGet("/books", () =>
{
    return Results.Ok(books);
});


// GET BOOK BY ID
app.MapGet("/books/{id}", (int id) =>
{
    var book = books.FirstOrDefault(b => b.Id == id);

    if (book == null)
    {
        return Results.NotFound("Book not found.");
    }

    return Results.Ok(book);
});


// CREATE BOOK
app.MapPost("/books", (BookDto dto) =>
{
    var book = new Book
    {
        Id = nextId++,
        Title = dto.Title,
        Author = dto.Author,
        Price = dto.Price
    };

    books.Add(book);

    return Results.Created($"/books/{book.Id}", book);
});


// UPDATE BOOK
app.MapPut("/books/{id}", (int id, BookDto dto) =>
{
    var book = books.FirstOrDefault(b => b.Id == id);

    if (book == null)
    {
        return Results.NotFound("Book not found.");
    }

    book.Title = dto.Title;
    book.Author = dto.Author;
    book.Price = dto.Price;

    return Results.Ok(book);
});


// DELETE BOOK
app.MapDelete("/books/{id}", (int id) =>
{
    var book = books.FirstOrDefault(b => b.Id == id);

    if (book == null)
    {
        return Results.NotFound("Book not found.");
    }

    books.Remove(book);

    return Results.Ok("Book deleted successfully.");
});


app.Run();