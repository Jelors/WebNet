using Microsoft.AspNetCore.Mvc;
using WebNet.Config.Classes;

[ApiController]
[Route("posts")]
public class PostsController : ControllerBase
{
    [HttpGet]
    public ActionResult<List<Post>> Get()
    {
        var posts = new List<Post>
        {
            new Post { Id = "1", Title = "Перший пост", Description = "Привіт із .NET!" },
            new Post { Id = "2", Title = "Другий пост", Description = "Це другий пост в списку." },
            new Post { Id = "3", Title = "Ще один", Description = "Просто тестовий контент." }
        };

        return Ok(posts);
    }
}
