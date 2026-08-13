using Microsoft.AspNetCore.DataProtection.KeyManagement;
using System;
using System.Text.Json;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.Run(async (HttpContext context) =>
{
    if(context.Request.Path.StartsWithSegments("/employees"))
    {
        if (context.Request.Method == "GET")
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
        else if(context.Request.Method == "POST")
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
        else if(context.Request.Method == "PUT")
        {
            try
            {
                // 1. Read and deserialize
                using var reader = new StreamReader(context.Request.Body);
                var body = await reader.ReadToEndAsync();
                var employee = JsonSerializer.Deserialize<Employee>(body);
                
                // 2. Validate
                if (employee == null || employee.Id <= 0)
                {
                    context.Response.StatusCode = 400; // Bad Request
                    await context.Response.WriteAsync("Invalid employee data");
                    return;
                }
                
                // 3. Attempt update
                var result = EmployeesRepository.UpdateEmployee(employee);
                
                // 4. Send appropriate response
                if (result)
                {
                    context.Response.StatusCode = 200; // OK
                    context.Response.ContentType = "application/json";
                    var json = JsonSerializer.Serialize(employee);
                    await context.Response.WriteAsync(json);
                }
                else
                {
                    context.Response.StatusCode = 404; // Not Found
                    await context.Response.WriteAsync($"Employee with ID {employee.Id} not found");
                }
            }
            catch (JsonException)
            {
                context.Response.StatusCode = 400; // Bad Request
                await context.Response.WriteAsync("Invalid JSON format");
            }
            catch (Exception ex)
            {
                context.Response.StatusCode = 500; // Internal Server Error
                await context.Response.WriteAsync($"Error: {ex.Message}");
            }
        }
        else if(context.Request.Method == "DELETE")
        {
            try
            {
                // 1. Check if ID parameter exists
                if (!context.Request.Query.ContainsKey("id"))
                {
                    context.Response.StatusCode = 400; // Bad Request
                    await context.Response.WriteAsync("Missing 'id' parameter. Use ?id=number");
                    return;
                }
                
                // 2. Get and parse ID
                var id = context.Request.Query["id"].ToString();
                if (!int.TryParse(id, out int employeeId))
                {
                    context.Response.StatusCode = 400; // Bad Request
                    await context.Response.WriteAsync($"Invalid ID format: '{id}'. ID must be a number.");
                    return;
                }
                
                // 3. Attempt deletion
                var result = EmployeesRepository.DeleteEmployee(employeeId);
                
                // 4. Send appropriate response
                if (result)
                {
                    context.Response.StatusCode = 204; // No Content
                    // 204 status usually doesn't have a body, but we'll keep it for learning
                    await context.Response.WriteAsync($"Employee with ID {employeeId} deleted successfully.");
                }
                else
                {
                    context.Response.StatusCode = 404; // Not Found
                    await context.Response.WriteAsync($"Employee with ID {employeeId} not found.");
                }
            }
            catch (Exception ex)
            {
                context.Response.StatusCode = 500; // Internal Server Error
                await context.Response.WriteAsync($"Error: {ex.Message}");
            }
        }
        else
        {
            // Not a GET,POST,PUT,DELETE request - return 405 Method Not Allowed
            context.Response.StatusCode = 405;
            await context.Response.WriteAsync("405 - Method Not Allowed. Only GET,POST,PUT,DELETE requests are supported.");
        }
    }
    else if (context.Request.Path == "/")
    {
        await context.Response.WriteAsync("Welcome to Employee API");
    }
    else
    {
        context.Response.StatusCode = 404;
        await context.Response.WriteAsync("Page not found");
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

    public static void AddEmployee(Employee? employee)
    {
        if (employee is not null)
        {
            employees.Add(employee);
        }
    }

    public static bool UpdateEmployee(Employee? employee)
    {
        if (employee is not null && !string.IsNullOrEmpty(employee.Name))
        {
            var emp = employees.FirstOrDefault(x => x.Id == employee.Id);
            if (emp is not null)
            {
                emp.Name = employee.Name;
                emp.Position = employee.Position ?? "Unknown"; // Default if null
                emp.Salary = employee.Salary > 0 ? employee.Salary : 0;
                return true;
            }
        }
        return false;
    }

    public static bool DeleteEmployee(int id)
    {
        var employee = employees.FirstOrDefault(x => x.Id == id);
        if (employee is not null)
        {
            employees.Remove(employee);
            return true;
        }
        
        return false;
    }
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