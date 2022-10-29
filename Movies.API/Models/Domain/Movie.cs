namespace Movies.API.Models.Domain
{
    public class Movie
    {
        public int Id { get; set; }

        public bool Adult{ get; set; }

        public string Backdrop_path { get; set; }

        public string Original_language { get; set; }

        public string Original_title { get; set; }

        public string Overview{ get; set; }

        public int Popularity { get; set; }

        public string Poster_path{ get; set; }

        public DateTime Release_date { get; set; }

        public string Title { get; set; }

        public bool Video { get; set; }

        public int vote_average { get; set; }

        public int vote_count { get; set; }

        

    }
}
