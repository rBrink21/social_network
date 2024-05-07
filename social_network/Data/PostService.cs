using social_network.Model;

namespace social_network.Data;

public class PostService
{
    private MyContext context;

    public PostService(MyContext _context)
    {
        context = _context;
    }

    public void CreatePost(PostData post)
    {
        post.postId = Guid.NewGuid();
        context.posts.Add(post);
        context.SaveChanges();
    }
    public List<PostData> GetAllPosts()
        {
            return context.posts.ToList();
        }
}