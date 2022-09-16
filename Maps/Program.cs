var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();


app.MapGet("/map", () =>
{
    var address =
        new Address
        ("1010 helloworld 4040 9090",
        "excaption",
        "error",
        "01"
        ); 
    return address;
});

app.Run();

internal record Address(string address, string city, string state, string zip)
{

}