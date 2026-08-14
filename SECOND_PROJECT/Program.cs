var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// 1. Logging Middleware
app.Use(async (context, next) =>
{
    Console.WriteLine($"[{DateTime.Now}] Request: {context.Request.Method} {context.Request.Path}");
    await next(context);
    Console.WriteLine($"[{DateTime.Now}] Response: {context.Response.StatusCode}");
});


// 3. Enable Routing
app.UseRouting();

// 5. Define Endpoints with Default Values
app.UseEndpoints(endpoints =>
{
    // ============================================
    // 1. GET - List employees with pagination defaults
    // URL: /employees → page=1, pageSize=10
    // URL: /employees/2 → page=2, pageSize=10
    // URL: /employees/2/20 → page=2, pageSize=20
    // ============================================
    endpoints.MapGet("/employees/{page=1}/{pageSize=10}", async (HttpContext context) =>
    {
        var page = context.Request.RouteValues["page"];
        var pageSize = context.Request.RouteValues["pageSize"];
        
        await context.Response.WriteAsync(
            $"GET: List of all employees - Page: {page}, Size: {pageSize}"
        );
    });

    // ============================================
    // 2. GET - Get employee by ID with optional include details
    // URL: /employees/5 → id=5, includeDetails="no"
    // URL: /employees/5/yes → id=5, includeDetails="yes"
    // ============================================
    endpoints.MapGet("/employees/{id}/{includeDetails=no}", async (HttpContext context) =>
    {
        var id = context.Request.RouteValues["id"];
        var includeDetails = context.Request.RouteValues["includeDetails"];
        
        var response = includeDetails?.ToString() == "yes" 
            ? $"GET: Employee with ID: {id} (with full details)"
            : $"GET: Employee with ID: {id} (basic info)";
        
        await context.Response.WriteAsync(response);
    });

    // ============================================
    // 3. GET - Filter employees by department with defaults
    // URL: /employees/filter → department="all", sortBy="name"
    // URL: /employees/filter/IT → department="IT", sortBy="name"
    // URL: /employees/filter/IT/salary → department="IT", sortBy="salary"
    // ============================================
    endpoints.MapGet("/employees/filter/{department=all}/{sortBy=name}", async (HttpContext context) =>
    {
        var department = context.Request.RouteValues["department"];
        var sortBy = context.Request.RouteValues["sortBy"];
        
        await context.Response.WriteAsync(
            $"GET: Employees in Department: {department}, Sorted by: {sortBy}"
        );
    });

    // ============================================
    // 4. GET - Search employees with multiple defaults
    // URL: /employees/search → q="", status="active", page=1
    // URL: /employees/search/john → q="john", status="active", page=1
    // URL: /employees/search/john/inactive → q="john", status="inactive", page=1
    // URL: /employees/search/john/inactive/2 → q="john", status="inactive", page=2
    // ============================================
    endpoints.MapGet("/employees/search/{q=}/{status=active}/{page=1}", async (HttpContext context) =>
    {
        var query = context.Request.RouteValues["q"];
        var status = context.Request.RouteValues["status"];
        var page = context.Request.RouteValues["page"];
        
        await context.Response.WriteAsync(
            $"GET: Search employees - Query: '{query}', Status: {status}, Page: {page}"
        );
    });

    // ============================================
    // 5. GET - Employee statistics with year/month defaults
    // URL: /employees/stats → year=2026, month=1
    // URL: /employees/stats/2026 → year=2026, month=1
    // URL: /employees/stats/2026/8 → year=2026, month=8
    // ============================================
    endpoints.MapGet("/employees/stats/{year=2026}/{month=1}", async (HttpContext context) =>
    {
        var year = context.Request.RouteValues["year"];
        var month = context.Request.RouteValues["month"];
        
        await context.Response.WriteAsync(
            $"GET: Employee statistics for {month}/{year}"
        );
    });

    // ============================================
    // 6. POST - Create employee with default role
    // URL: /employees → default role="Junior"
    // URL: /employees/senior → role="Senior"
    // ============================================
    endpoints.MapPost("/employees/{role=Junior}", async (HttpContext context) =>
    {
        var role = context.Request.RouteValues["role"];
        await context.Response.WriteAsync(
            $"POST: Create a new employee with role: {role}"
        );
    });

    // ============================================
    // 7. PUT - Update employee with optional fields
    // URL: /employees/5 → id=5, updateType="basic"
    // URL: /employees/5/full → id=5, updateType="full"
    // ============================================
    endpoints.MapPut("/employees/{id}/{updateType=basic}", async (HttpContext context) =>
    {
        var id = context.Request.RouteValues["id"];
        var updateType = context.Request.RouteValues["updateType"];
        
        await context.Response.WriteAsync(
            $"PUT: Update employee with ID: {id} - {updateType} update"
        );
    });

    // ============================================
    // 8. DELETE - Delete employee with optional cascade
    // URL: /employees/5 → id=5, cascade="no"
    // URL: /employees/5/yes → id=5, cascade="yes"
    // ============================================
    endpoints.MapDelete("/employees/{id}/{cascade=no}", async (HttpContext context) =>
    {
        var id = context.Request.RouteValues["id"];
        var cascade = context.Request.RouteValues["cascade"];
        
        var response = cascade?.ToString() == "yes"
            ? $"DELETE: Remove employee with ID: {id} (cascade delete enabled)"
            : $"DELETE: Remove employee with ID: {id} (soft delete)";
        
        await context.Response.WriteAsync(response);
    });

    // ============================================
    // 9. Advanced: Multi-parameter with defaults
    // URL: /employees/advanced → dept="all", minSalary=0, maxSalary=100000, page=1
    // URL: /employees/advanced/IT → dept="IT", minSalary=0, maxSalary=100000, page=1
    // URL: /employees/advanced/IT/50000 → dept="IT", minSalary=50000, ...
    // URL: /employees/advanced/IT/50000/100000 → dept="IT", minSalary=50000, maxSalary=100000
    // URL: /employees/advanced/IT/50000/100000/2 → dept="IT", minSalary=50000, maxSalary=100000, page=2
    // ============================================
    endpoints.MapGet("/employees/advanced/{department=all}/{minSalary=0}/{maxSalary=100000}/{page=1}", 
        async (HttpContext context) =>
    {
        var dept = context.Request.RouteValues["department"];
        var minSalary = context.Request.RouteValues["minSalary"];
        var maxSalary = context.Request.RouteValues["maxSalary"];
        var page = context.Request.RouteValues["page"];
        
        await context.Response.WriteAsync(
            $"GET: Advanced search - Dept: {dept}, Salary Range: {minSalary} - {maxSalary}, Page: {page}"
        );
    });

    // ============================================
    // 10. Versioning API with default version
    // URL: /api/employees → version=1
    // URL: /api/v2/employees → version=2
    // ============================================
    endpoints.MapGet("/api/v{version=1}/{controller=employees}", 
        async (HttpContext context) =>
    {
        var version = context.Request.RouteValues["version"];
        var controller = context.Request.RouteValues["controller"];
        
        await context.Response.WriteAsync(
            $"GET: API v{version} - {controller} controller"
        );
    });
});

app.Run();