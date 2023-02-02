using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SportClub.Web;
using SportClub.Web.Services;
using SportClub.Web.Services.Contracts;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
// In Swagger UI: https://localhost:7296/api/Schedule/GetTodaysLessons

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7296/") });

// For more complex application a Service can be applied
// (in the inline course used, but not needed here
//builder.Services.AddScoped<IScheduleService, ScheduleService>();

await builder.Build().RunAsync();
