<<<<<<< HEAD
/*
=======
>>>>>>> b45826d1fd259302da5381a25569fc3cce90adf2
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast =  Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
<<<<<<< HEAD
*/

using Microsoft.OpenApi.Models;

// alias สำหรับชัดเจน
using WebApiServices = Begin00.WebApi.Services;
using ZooServices = Begin00.Services; // Begin00.Services.Zoo

var builder = WebApplication.CreateBuilder(args);

// -------------------------
// Register Zoo และ Services
// -------------------------
builder.Services.AddSingleton<ZooServices.Zoo>(); // Zoo singleton
builder.Services.AddSingleton<WebApiServices.IAnimalService, WebApiServices.AnimalService>();
builder.Services.AddSingleton<WebApiServices.IVoiceService, WebApiServices.VoiceService>();

// -------------------------
// Add Controllers
// -------------------------
builder.Services.AddControllers();

// -------------------------
// Add Swagger/OpenAPI
// -------------------------
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Zoo & Voice API",
        Version = "v1",
        Description = "API สำหรับจัดการสัตว์และเสียงสัตว์"
    });
});

// -------------------------
// Build App
// -------------------------
var app = builder.Build();

// -------------------------
// Enable Swagger UI
// -------------------------
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Zoo & Voice API v1");
        c.RoutePrefix = string.Empty; // Swagger เปิดที่ root
    });
}

// ปิด HTTPS Redirect เพื่อไม่ให้ warning
// app.UseHttpsRedirection();

app.UseAuthorization();

// Map Controllers
app.MapControllers();

app.Run();
=======
>>>>>>> b45826d1fd259302da5381a25569fc3cce90adf2
