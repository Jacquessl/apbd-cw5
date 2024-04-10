using WebApplication1.DataBase;
using WebApplication1.Model;

StaticData.AddAnima(new Animal(0, "daf", "daf", 10.0, "ads"));
StaticData.AddAnima(new Animal(1, "daa", "da", 20.0, "adds"));
StaticData.AddAnima(new Animal(2, "das", "faga", 13.0, "fa"));
StaticData.AddAnima(new Animal(3, "dad", "gagaga", 14.0, "da"));
StaticDataVisits.AddVisit(new Visit(0, DateTime.Parse("2022-01-10"), 2, "nice", 345.9));
StaticDataVisits.AddVisit(new Visit(1, DateTime.Parse("2022-11-11"), 1, "not nice", 140.0));
StaticDataVisits.AddVisit(new Visit(2, DateTime.Parse("2022-11-12"), 3, "not nice", 322.4));
StaticDataVisits.AddVisit(new Visit(3, DateTime.Parse("2023-02-01"), 0, "nice", 120.5));
StaticDataVisits.AddVisit(new Visit(4, DateTime.Parse("2023-03-10"), 2, "nice", 400.0));
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


// app.MapAnimalEndpoints();

app.MapControllers();

Console.WriteLine();
app.Run();
