﻿using BlazorPrettyCode;
using BlazorStrap;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using SampleCore;
using System.Threading.Tasks;

namespace Sample
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            WebAssemblyHostBuilder builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.Services.AddBaseAddressHttpClient();
            builder.Services.AddBootstrapCss();
            builder.Services.AddBlazorPrettyCode(defaults =>
            {
                defaults.DefaultTheme = "SolarizedDark";
                defaults.ShowLineNumbers = true;
            });
            
            builder.RootComponents.Add<App>("app");

            await builder.Build().RunAsync();
        }
    }
}
