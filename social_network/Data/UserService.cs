using Microsoft.EntityFrameworkCore;
using social_network.Model;

namespace social_network.Data;

public class UserService 
{
    private MyContext context;
    public UserService(MyContext _context) 
    {
        context = _context;
    }

    public void AddUser(User user) 
    { 
        user.userID = Guid.NewGuid();
        
        context.users.Add(user);
        context.SaveChanges();
    }
    // God i love LINQ
    public User? FindUserByUsername(string username)
    {
        return context.users.Include(u => u.friends).FirstOrDefault(u => u.username == username);
    }

    public async Task<User?> FindUserByUsernameAsync(string username)
    {
        return await context.users.Include(u => u.friends).FirstOrDefaultAsync(u => u.username == username);
    }
    
    public bool UsernameExists(string username)
    {
        return context.users.Any(u => u.username == username);
    }

    public bool VerifyLogin(string username, string password)
    {
        User? user = FindUserByUsername(username);
        if (user != null)
        {
            return user.password == password;
        }
        return false;
    }

    public void SaveChanges()
    {
        context.SaveChanges();
    }
}