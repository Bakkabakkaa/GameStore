namespace GameStore.Api.DTO;

public record CreateGameDto(
    string Name,
    string Genre,
    decimal Price,
    DateOnly ReleaseDate
    );