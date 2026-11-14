using System.Text.Json;
using BattleGameFunctions.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BattleGameFunctions.Data

public class GameDbContextFactory : IDesignTimeDbContextFactory<GameDbContext>
{
    public GameDbContext CreateDbContext(string[] args)
    {
        var directory = new DirectoryInfo(Directory.GetCurrentDirectory());
        string? settingsPath = null;
        while (directory != null)
                    {
            var potentialSettingsPath = Path.Combine(directory.FullName, "appsettings.json");
            if (File.Exists(potentialSettingsPath))
            {
                settingsPath = potentialSettingsPath;
                break;
            }
            directory = directory.Parent;
        }
        if (string.IsNullOrEmpty(settingsPath))
        {
            throw new InvalidOperationException("Settings file 'appsettings.json' not found.");
        }
        var settingsContent = File.ReadAllText(settingsPath);
        var settings = JsonSerializer.Deserialize<Dictionary<string, object>>(settingsContent);
        var connectionString = settings.GetValueOrDefault("ConnectionStrings", new Dictionary<string, object>()).GetValueOrDefault("SqlConnectionString", null) as string;
        if (string.IsNullOrEmpty(connectionString))
        {
            throw new InvalidOperationException("Connection string 'SqlConnectionString' not found.");
        }
        var optionsBuilder = new DbContextOptionsBuilder<GameDbContext>();
        optionsBuilder.UseSqlServer(connectionString);
        return new GameDbContext(optionsBuilder.Options);
    }
}