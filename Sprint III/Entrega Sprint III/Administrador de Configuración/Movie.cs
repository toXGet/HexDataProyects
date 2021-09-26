using System;

namespace HexDataMovies.Shared.Entity
{
    public class Movie
    {
        public string Title {get;set;}
        public string Poster {get;set;}
        public string Sinopsis {get;set;}
        public string Genero {get;set;}
        public string Language {get;set;}
        public string Country {get;set;}
        public float Score {get;set;}
        public TimeSpan RunningTime {get;set;}
        public DateTime Premier {get;set;}
    }
}