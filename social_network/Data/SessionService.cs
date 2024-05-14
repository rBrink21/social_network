using social_network.Model;

namespace social_network.Data;

public class SessionService
{
    public string loggedInUser { get; set; }
    
    public void LoginUser(string username)
    {
        loggedInUser = username;
    }
}