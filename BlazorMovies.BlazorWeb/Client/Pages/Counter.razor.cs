using BlazorMovies.BlazorWeb.Client.Services;
using BlazorMovies.BlazorWeb.Shared.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
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
        [Inject] IJSRuntime js { get; set; }

        private List<Movie> movies;
        private int currentCount = 0;
        private static int currentCountStatic = 0;

        protected override void OnInitialized()
        {
            movies = new List<Movie>()
    {
            new Movie(){Title = "Joker",ReleaseDate = new DateTime(2019, 7, 2)},
            new Movie(){Title = "Avengers",ReleaseDate = new DateTime(2016,11,23)}
        };
        }

        [JSInvokable]
        public async Task IncrementCount()
        {
            currentCount++;
            currentCountStatic++;
            singleton.Value = currentCount;
            transient.Value = currentCount;
            await js.InvokeVoidAsync("dotnetStaticInvocation");
        }

        private async Task IncrementCountJavaScript()
        {
            await js.InvokeVoidAsync("dotnetInstanceInvocation",
                DotNetObjectReference.Create(this));
        }

        [JSInvokable]
        public static Task<int> GetCurrentCount()
        {
            return Task.FromResult(currentCountStatic);
        }
    }
}
