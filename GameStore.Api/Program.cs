using GameStore.Api.Data;
using GameStore.Api.Endpoints;

var connString = "Data Source=GameStore.db";
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddValidation();
builder.Services.AddSqlite<GameStoreContext>(connString);

var app = builder.Build();

app.MapGamesEndpoints();

app.Run();