using Microsoft.AspNetCore.DataProtection.KeyManagement;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.Run(async (HttpContext context) =>
{
    // Step 1: Check HTTP method
    if (context.Request.Method == "GET")
    {
        // Step 2: Route based on path (MOST SPECIFIC FIRST)
        
        // Route 1: /employees - Show employee list
        if (context.Request.Path.StartsWithSegments("/employees"))
        {
            var employees = EmployeesRepository.GetEmployees();
            
            await context.Response.WriteAsync("Employee List:\r\n");
            await context.Response.WriteAsync("================\r\n");
            
            foreach (var employee in employees) 
            {
                await context.Response.WriteAsync(
                    $"{employee.Id}. {employee.Name} - {employee.Position} (${employee.Salary})\r\n"
                );
            }
        }
        // Route 2: / - Show home page
        else if (context.Request.Path == "/")
        {
            await context.Response.WriteAsync($"The method is: {context.Request.Method}\r\n");
            await context.Response.WriteAsync($"The Url is: {context.Request.Path}\r\n");
            await context.Response.WriteAsync($"\r\nHeaders:\r\n");
            
            foreach (var key in context.Request.Headers.Keys)
            {
                await context.Response.WriteAsync($"{key}: {context.Request.Headers[key]}\r\n");
            }
        }
        // Route 3: Everything else - 404 Not Found
        else
        {
            context.Response.StatusCode = 404;
            await context.Response.WriteAsync($"404 - Page '{context.Request.Path}' not found");
        }
    }
    else if (context.Request.Method == "POST")
    {
        if (context.Request.Path.StartsWithSegments("/employees"))
        {
            try
            {
                // Read the body
                using var reader = new StreamReader(context.Request.Body);
                var body = await reader.ReadToEndAsync();
                
                // Deserialize to Employee
                var employee = JsonSerializer.Deserialize<Employee>(body);
                
                // Validate
                if (employee == null)
                {
                    context.Response.StatusCode = 400;
                    await context.Response.WriteAsync("Invalid employee data");
                    return;
                }
                
                // Add to repository
                EmployeesRepository.AddEmployee(employee);
                
                // Send success response
                context.Response.StatusCode = 201; // Created
                await context.Response.WriteAsync($"Employee {employee.Name} added successfully!");
            }
            catch (JsonException)
            {
                context.Response.StatusCode = 400;
                await context.Response.WriteAsync("Invalid JSON format");
            }
        }
    }
    else
    {
        // Not a GET,POST request - return 405 Method Not Allowed
        context.Response.StatusCode = 405;
        await context.Response.WriteAsync("405 - Method Not Allowed. Only GET,POST requests are supported.");
    }
});

app.Run();

static class EmployeesRepository
{
    private static List<Employee> employees = new List<Employee>
    {
        new Employee(1, "John Doe", "Engineer", 60000),
        new Employee(2, "Jane Smith", "Manager", 75000),
        new Employee(3, "Sam Brown", "Technician", 50000)
    };

    public static List<Employee> GetEmployees() => employees;
}

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Position { get; set; }
    public double Salary { get; set; }

    public Employee(int id, string name, string position, double salary)
    {
        Id = id;
        Name = name;
        Position = position;
        Salary = salary;
    }
}