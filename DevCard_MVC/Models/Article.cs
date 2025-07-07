namespace DevCard_MVC.Models
{
    public class Article
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }

        public Article(long id, string title,  string description ,string picture)
        {
            Id = id;
            Title = title;
           
            Description = description;
            Picture = picture;
        }
    }


}
