namespace WebNet.Models
{
    public class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }

        public News(int id, string title, string text)
        {
            Id = id;
            Title = title;
            Text = text;
        }
    }
}
