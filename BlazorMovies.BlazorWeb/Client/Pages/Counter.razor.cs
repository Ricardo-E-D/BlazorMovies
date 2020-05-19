using BlazorMovies.BlazorWeb.Shared.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static BlazorMovies.BlazorWeb.Client.Shared.MainLayout;

namespace BlazorMovies.BlazorWeb.Client.Pages
{
    public partial class Counter
    {
        private int currentCount = 0;

        public void IncrementCount()
        {
            currentCount++;
        }
    }
}
