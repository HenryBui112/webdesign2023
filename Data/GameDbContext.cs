using BattleGameFunctions.Models;
using Microsoft.EntityFrameworkCore;

namespace BattleGameFunctions.Data;

public class GameDbContext : DbContext
{
   public GameDbContext(DbContextOptions<GameDbContext> options) : base(options)
    {
    }

    public DbSet<Player> Players { get; set; } = null!;
    public DbSet<Assets> Assets { get; set; } = null!;
    public DbSet<PlayerAsset> PlayerAssets { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // Cấu hình quan hệ nhiều-nhiều giữa Player và Assets thông qua PlayerAsset
        modelBuilder.Entity<PlayerAsset>()
            .HasKey(pa => new { pa.PlayerId, pa.AssetId });
        modelBuilder.Entity<PlayerAsset>()
            .HasOne(pa => pa.Player)
            .WithMany(p => p.PlayerAssets)
            .HasForeignKey(pa => pa.PlayerId);
        modelBuilder.Entity<PlayerAsset>()
            .HasOne(pa => pa.Asset)
            .WithMany(a => a.PlayerAssets)
            .HasForeignKey(pa => pa.AssetId);
        modelBuilder.Entity<Player>()
            .HasIndex(p => p.PlayerName)
            .IsUnique();
    }

}