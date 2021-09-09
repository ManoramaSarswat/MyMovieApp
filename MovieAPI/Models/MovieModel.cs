using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

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

        public string Title { get; set; }

        public string imdbID { get; set; }

        public string listingType { get; set; }
        
        public string imdbRating { get; set; }

        // private static readonly char delimiter = ';';
        // private string SoundEffects;
        // [NotMapped]
        // public string[] _soundEffects { 
        //     get { return SoundEffects.Split(delimiter); }
        //     set
        //     {
        //         SoundEffects = string.Join($"{delimiter}", value);
        //     }
        //  }

        // private string Stills;
        // [NotMapped]
        // public string[] _stills { 
        //     get { return Stills.Split(delimiter); }
        //     set
        //     {
        //         Stills = string.Join($"{delimiter}", value);
        //     }
        //  }
    }

    public class Movies
    {
        public List<MovieModel> movies { get; set; }
    }
}