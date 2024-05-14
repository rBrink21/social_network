using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;

namespace social_network.Model;

public class User
{
    [Key]
    public Guid userID { get; set; }
    [Required]
    public string firstName { get; set; }
    [Required]
    public string lastName { get; set; }
    [Required]
    public string username { get; set; }
    [Required]
    [EmailAddress]
    public string email { get; set; }
    [Required]
    [MinLength(6)]
    public string password { get; set; }
    [Required]
    public DateTime birthDate { get; set; }
    [MaxLength(100)]
    public string? profilePictureUrl { get; set; }

    public List<User> friends { get; set; } = new List<User>();


    public string GetProfilePic()
    {
        if (profilePictureUrl == null)
        {
            return "https://i.imgur.com/g8mfuk3.png";
        }
        else
        {
            return profilePictureUrl;
        }
    }
}