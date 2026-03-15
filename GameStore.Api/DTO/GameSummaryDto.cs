namespace GameStore.Api.DTO;

/// <summary>
/// A DTO is a contract between the client and server
/// since it represents a shared agreement about how
/// data will be transferred and used.
/// </summary>
public record GameSummaryDto(
    int Id,
    string Name,
    string Genre,
    decimal Price,
    DateOnly ReleaseDate
    );
    