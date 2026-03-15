using GameStore.Api.Data;
using GameStore.Api.Endpoints;
using GameStore.Api.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddValidation();
builder.AddGamesStoreDb();

var app = builder.Build();

app.MapGamesEndpoints();
app.MigrateDb();

app.Run();