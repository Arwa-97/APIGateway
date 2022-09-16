var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();


app.MapGet("/vehicle", () =>
{
    var car = new Car(
        1,
        "flywieght",
        "spinning around failure",
        "new"
        );
    return car;
});

app.Run();

internal record Car(int Id, string model, string location, string condition)
{ }
   