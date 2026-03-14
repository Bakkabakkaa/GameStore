using GameStore.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Api.Data;

public class GameStoreContext : DbContext
{
    public DbSet<Game> Games => Set<Game>();
    
    public DbSet<Genre> Genres => Set<Genre>();
    
    public GameStoreContext(DbContextOptions<GameStoreContext> options) : base(options)
    {
    }
}