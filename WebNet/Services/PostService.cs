using System.Net.Http;
using System.Text.Json;
using WebNet.Config.Classes;

public class PostService
{
    private readonly HttpClient _http;

    public PostService(HttpClient http)
    {
        _http = http;
    }

    //public async Task<List<Post>> GetPostsAsync()
    //{
    //    var response = await _http.GetAsync("http://localhost:3000/posts");

    //    if (!response.IsSuccessStatusCode)
    //    {
    //        var error = await response.Content.ReadAsStringAsync();
    //        Console.WriteLine($"❌ Failed to fetch posts: {error}");
    //        return new List<Post>();
    //    }

    //    var json = await response.Content.ReadAsStringAsync();
    //    var posts = JsonSerializer.Deserialize<List<Post>>(json, new JsonSerializerOptions
    //    {
    //        PropertyNameCaseInsensitive = true
    //    });

    //    return posts ?? new List<Post>();
    //}
}
