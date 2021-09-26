using HexDataMovies.Shared.Entity;
using System.Collections.Generic;

namespace HexDataMovies.Client.Services
{
    public interface IServiceMovie
    {
        List<Movie> GetMovies();
    }
}