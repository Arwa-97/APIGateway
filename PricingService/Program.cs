var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();


app.MapGet("/price", () =>
{
    var price =
        new Price
        (
            "bitcoin",
            new decimal(52369874.254),
            1
        );
    return price;
});

app.Run();

internal record Price(string currency, decimal price, int vehicleId)
{
}