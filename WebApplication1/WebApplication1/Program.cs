using WebApplication1.DataBase;
using WebApplication1.EndPoints;
using WebApplication1.Model;

StaticData.AddAnima(new Animal(0, "daf", "daf", 10.0, "ads"));
StaticData.AddAnima(new Animal(1, "daa", "da", 20.0, "adds"));
StaticData.AddAnima(new Animal(2, "das", "faga", 13.0, "fa"));
StaticData.AddAnima(new Animal(3, "dad", "gagaga", 14.0, "da"));
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


app.MapAnimalEndpoints();

app.MapControllers();
Console.WriteLine();
app.Run();
