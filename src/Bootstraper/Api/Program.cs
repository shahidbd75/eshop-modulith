using Catelog;
using Basket;
using Ordering;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

builder.Services
    .AddCatelogModule(builder.Configuration)
    .AddBusketModule(builder.Configuration)
    .AddOrderingModule(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.

app
    .UseCatelogModule()
    .UseBasketModule()
    .UseOrderingModule();

app.Run();
