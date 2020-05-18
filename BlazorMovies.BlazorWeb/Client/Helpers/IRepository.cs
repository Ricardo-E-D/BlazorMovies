using BlazorMovies.BlazorWeb.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.BlazorWeb.Client.Helpers
{
    public interface IRepository
    {
        List<Movie> GetMovies();
    }
}
