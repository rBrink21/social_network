using Microsoft.EntityFrameworkCore;

namespace social_network.Data;

public class MyContext : DbContext
{
    public MyContext(DbContextOptions<MyContext> options) : base(options)
    {
    }

}