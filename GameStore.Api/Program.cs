using GameStore.Api.DTO;

const string GetGameEndpointName = "GetGame";
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

// GET /games/1
app.MapGet("/games/{id}", (int id) =>
{
    return games.Find(game => game.Id == id);
}).WithName(GetGameEndpointName);

// POST /games
app.MapPost("/games", (CreateGameDto newGame) =>
{
    GameDto game = new GameDto(games.Count + 1, newGame.Name, newGame.Genre, newGame.Price, newGame.ReleaseDate);
    
    games.Add(game);
    
    return Results.CreatedAtRoute(GetGameEndpointName, new {id = game.Id}, game);
});

app.Run();