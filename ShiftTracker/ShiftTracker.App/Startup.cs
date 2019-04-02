using Microsoft.AspNetCore.Blazor.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;

namespace ShiftTracker.App
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            
           
        }

        public void Configure(IBlazorApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
