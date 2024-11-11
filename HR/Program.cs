using HR.Application.Ports;
using HR.Application.Services;
using HR.Infrastructure.Adapters.Messages;
using HR.Infrastructure.Adapters.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var serviceProvider = new ServiceCollection()
    .AddLogging(config =>
    {
        config.AddConsole(); 
        config.SetMinimumLevel(LogLevel.Information); 
    })
    .BuildServiceProvider();

builder.Services.AddScoped<IStockMessage, StockMessage>();
builder.Services.AddScoped<IStockService, StockService>();
builder.Services.AddScoped<IStockRepository, StockRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
