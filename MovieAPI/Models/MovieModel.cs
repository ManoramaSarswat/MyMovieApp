using System.Collections.Generic;

namespace MovieAPI.Models
{
    public class MovieModel
    {
        public int Id { get; set; }

        public string MovieName { get; set; }

        public string Language { get; set; }

        public string Location { get; set; }

        public string Plot { get; set; }

        public string Poster { get; set; }

        public string SoundEffects { get; set; }

        public string Stills { get; set; }

        public string Title { get; set; }

        public string ImdbId { get; set; }

        public string ListingType { get; set; }
        
        public string ImdbRating { get; set; }
    }
}