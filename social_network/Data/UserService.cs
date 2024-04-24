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
}