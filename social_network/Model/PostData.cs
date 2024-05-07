using System.ComponentModel.DataAnnotations;

namespace social_network.Model;

public class PostData
{
    [Key]
    public Guid postId { get; set; }
    public string username { get; set; }
    [Required]
    public string textContent { get; set; }
    public DateTime postDate { get; set; }

    public PostData()
    {
        
    }

    public PostData(string _username, string _textContent)
    {
        username = _username;
        textContent = _textContent;
        postDate = DateTime.Now;
    }
}