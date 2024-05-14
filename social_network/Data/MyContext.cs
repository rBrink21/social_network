using Microsoft.EntityFrameworkCore;
using social_network.Model;

namespace social_network.Data;

public class MyContext : DbContext
{
    public MyContext(DbContextOptions<MyContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .HasMany(u => u.friends)
            .WithMany();
    }

    public DbSet<User> users { get; set; }
    public DbSet<PostData> posts { get; set; }
}