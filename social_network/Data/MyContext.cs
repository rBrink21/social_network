using Microsoft.EntityFrameworkCore;
using social_network.Model;

namespace social_network.Data;

public class MyContext : DbContext
{
    public MyContext(DbContextOptions<MyContext> options) : base(options)
    {
    }
    
    public DbSet<User> users { get; set; }
}