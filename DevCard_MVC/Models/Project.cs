namespace DevCard_MVC.Models
{
    public class Project
    {
        public long Id { get; set; }
        public string Name { get; set; }
     
        public string Description { get; set; }
        public string Picture { get; set; }
        public string Client { get; set; }

        public Project(long id, string name,  string description, string picture, string client)
        {
            Id = id;
            Name = name;
            
            Description = description;
            Picture = picture;
            Client = client;
        }
    }


}
