namespace Movies.API.Models.Domain
{
    public class Genre
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Title { get; set; }

        public int MoviesId { get; set; }

    }
}
