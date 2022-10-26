namespace Proje
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public Movie(int ıd, string film, string description, string ımageUrl)
        {
            this.Id = ıd;
            this.Name = film;
            this.Description = description;
            this.ImageUrl = ımageUrl;
        }
    }
}
