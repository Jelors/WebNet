using WebNet.Config.Interfaces;

namespace WebNet.Config.Classes
{
    public class Post : IPost
    {
        public string Id { get; set; }
        public string? Author { get ; set ; }
        public string? Title { get ; set; }
        public string? Description { get; set; }
    }
}
