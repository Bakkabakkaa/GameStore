using GameStore.Api.DTO;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<GameDto> games = new List<GameDto>()
{
    new GameDto(1, "Street Fighter 2", "Fighting", 19.99M, new DateOnly(1992, 7, 15)),
    new GameDto(2, "Final Fantasy 7 Rebirth", "RPG", 69.99M, new DateOnly(2024, 2, 29)),
    new GameDto(3, "Astro Bot", "Platformer", 59.99M, new DateOnly(2024, 9, 6))
};

// GET /games
app.MapGet("/games", () => games);

app.Run();