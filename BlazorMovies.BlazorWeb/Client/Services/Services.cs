using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.BlazorWeb.Client.Services
{
    public class SingletonService
    {
        public int Value { get; set; }
    }
    public class TransientService
    {
        public int Value { get; set; }
    }
}
