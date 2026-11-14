using System.Net;
using System.Text.Json;
using BattleGameFunctions.Data;
using BattleGameFunctions.DTOs;
using BattleGameFunctions.Models;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.EntityFrameworkCore;


namespace BattleGameFunctions.DTO;

public class RegisterPlayerFunction
{
    private readonly GameDbContext _dbContext;
    public RegisterPlayerFunction(GameDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    [Function("RegisterPlayer")]
    public async Task<HttpResponseData> Run([HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "register")] HttpRequestData req)
    {
        var requestBody = await new StreamReader(req.Body).ReadToEndAsync();
        var registerRequest = JsonSerializer.Deserialize<RegisterPlayerRequest>(requestBody);
        if (registerRequest == null || string.IsNullOrEmpty(registerRequest.PlayerName))
        {
            var badResponse = req.CreateResponse(HttpStatusCode.BadRequest);
            await badResponse.WriteStringAsync("Invalid request payload.");
            return badResponse;
        }
        var player = new Player
        {
            PlayerName = registerRequest.PlayerName,
            Fullname = registerRequest.Fullname,
            Age = registerRequest.Age,
            Level = registerRequest.Level
        };
        _dbContext.Players.Add(player);
        await _dbContext.SaveChangesAsync();
        var response = req.CreateResponse(HttpStatusCode.Created);
        await response.WriteStringAsync($"Player '{player.PlayerName}' registered successfully with ID: {player.PlayerId}");
        return response;
    }
}