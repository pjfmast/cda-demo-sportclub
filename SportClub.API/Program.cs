using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using SportClub.API.Data;
using SportClub.API.Repositories;
using SportClub.API.Repositories.Contracts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Les 2. For using EF with SportClubContext
builder.Services.AddDbContext<SportClubDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("SportClubDbConnection"))
);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Added for SportClub
//builder.Services.AddScoped<ISportClubRepository, SportClubInMemoryRepository>();
// Les 2. For using EF with SportClubContext
builder.Services.AddScoped<ISportClubRepository, SportClubDbRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
// See: https://learn.microsoft.com/en-us/aspnet/core/security/cors?view=aspnetcore-7.0#attr
app.UseCors(policy =>
    policy.WithOrigins("http://localhost:7212", "https://localhost:7212")
    .AllowAnyMethod()
    .WithHeaders(HeaderNames.ContentType)
);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
