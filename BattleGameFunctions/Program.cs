using BattleGameFunctions.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = new HostBuilder()
    .ConfigureFunctionsWebApplication()
    .ConfigureServices((context, services) =>
    {
    var connectionString = context.Configuration.GetConnectionString("SqlConnectionString");
    if string.IsNullOrEmpty(connectionString))
        {
        throw new InvalidOperationException("Connection string 'SqlConnectionString' not found.");
            );
    }
services.AddDbContext<GameDbContext>(options =>
        options.UseSqlServer(connectionString));
    };
})
.Build();

host.Run(); 