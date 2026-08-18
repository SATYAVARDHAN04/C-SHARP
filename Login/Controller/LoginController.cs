using Login.DTO;
using Login.Data;
using Login.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;


public class LoginController : ControllerBase
{
    private readonly LoginDbcontext _context;
    public LoginController(LoginDbcontext context)
    {
        _context = context;
    }
    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginDTO loginDTO)
    {
        var user = await _context.Logins
            .FirstOrDefaultAsync(u => u.Username == loginDTO.Username && u.Password == loginDTO.Password);
        if (user == null)
        {
            return Unauthorized();
        }
        // Here you would typically generate a JWT token or set a session cookie
        // For simplicity, we will just return a success message
        return Ok(new { message = "Login successful" });
    }
}