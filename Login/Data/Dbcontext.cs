namespace Login.Data
{
    using Microsoft.EntityFrameworkCore;
    using Login.Model;
    public class LoginDbcontext : DbContext
    {
        public LoginDbcontext(DbContextOptions<LoginDbcontext> options) : base(options)
        {
        }
        public DbSet<Login> Logins { get; set; }
    }
}