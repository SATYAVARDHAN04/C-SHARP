using LoginSignup.Api.Data;
using LoginSignup.Api.DTOs;
using LoginSignup.Api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


// --------------------------------------------------
// Database
// --------------------------------------------------

var connectionString =
    builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString));


// --------------------------------------------------
// Password hashing
// --------------------------------------------------

builder.Services.AddScoped<IPasswordHasher<User>, PasswordHasher<User>>();


// --------------------------------------------------
// CORS
// --------------------------------------------------

builder.Services.AddCors(options =>
{
    options.AddPolicy("Frontend", policy =>
    {
        policy
            .WithOrigins(
                "http://127.0.0.1:5500",
                "http://localhost:5500"
            )
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});


var app = builder.Build();


// --------------------------------------------------
// Middleware
// --------------------------------------------------

app.UseCors("Frontend");


// --------------------------------------------------
// Test endpoint
// --------------------------------------------------

app.MapGet("/", () =>
{
    return "LoginSignup API is running!";
});


// --------------------------------------------------
// SIGNUP
// --------------------------------------------------

app.MapPost("/api/auth/signup",
    async (
        SignupRequest request,
        AppDbContext db,
        IPasswordHasher<User> passwordHasher) =>
    {
        // Basic validation
        if (string.IsNullOrWhiteSpace(request.Name) ||
            string.IsNullOrWhiteSpace(request.Email) ||
            string.IsNullOrWhiteSpace(request.Password))
        {
            return Results.BadRequest(new
            {
                message = "All fields are required."
            });
        }


        // Check whether email already exists
        var existingUser = await db.Users
            .FirstOrDefaultAsync(u => u.Email == request.Email);

        if (existingUser != null)
        {
            return Results.Conflict(new
            {
                message = "An account with this email already exists."
            });
        }


        // Create user
        var user = new User
        {
            Name = request.Name,
            Email = request.Email,
            CreatedAt = DateTime.UtcNow
        };


        // Hash password
        user.PasswordHash =
            passwordHasher.HashPassword(user, request.Password);


        // Save user
        db.Users.Add(user);

        await db.SaveChangesAsync();


        return Results.Ok(new
        {
            message = "Account created successfully."
        });
    });


// --------------------------------------------------
// LOGIN
// --------------------------------------------------

app.MapPost("/api/auth/login",
    async (
        LoginRequest request,
        AppDbContext db,
        IPasswordHasher<User> passwordHasher) =>
    {
        // Find user
        var user = await db.Users
            .FirstOrDefaultAsync(u => u.Email == request.Email);

        if (user == null)
        {
            return Results.Unauthorized();
        }


        // Verify password
        var passwordResult =
            passwordHasher.VerifyHashedPassword(
                user,
                user.PasswordHash,
                request.Password);


        if (passwordResult == PasswordVerificationResult.Failed)
        {
            return Results.Unauthorized();
        }


        return Results.Ok(new
        {
            message = "Login successful!"
        });
    });


app.Run();