using BlazorMovies.BlazorWeb.Client.Services;
using BlazorMovies.BlazorWeb.Shared.Entities;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.BlazorWeb.Client.Pages
{
    public partial class Counter
    {
        [Inject] SingletonService singleton { get; set; }
        [Inject] TransientService transient { get; set; }

        private List<Movie> movies;
        private int currentCount = 0;

        protected override void OnInitialized()
        {
            movies = new List<Movie>()
    {
            new Movie(){Title = "Joker",ReleaseDate = new DateTime(2019, 7, 2)},
            new Movie(){Title = "Avengers",ReleaseDate = new DateTime(2016,11,23)}
        };
        }

        private void IncrementCount()
        {
            currentCount++;
            singleton.Value = currentCount;
            transient.Value = currentCount;
        }
    }
}
