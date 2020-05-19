using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using BlazorMovies.BlazorWeb.Client.Helpers;

namespace BlazorMovies.BlazorWeb.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            ConfigureServices(builder.Services);
            builder.Services.AddBaseAddressHttpClient();

            await builder.Build().RunAsync();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddOptions();  //future usage for Authorization System
            services.AddTransient<IRepository, RepositoryInMemory>();
        }
    }
}
