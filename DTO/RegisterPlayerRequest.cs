namespace BattleGameFunctions.DTO;

public class RegisterPlayerRequest
{
    public string? PlayerName { get; set; } = string.Empty;
    public string? Fullname { get; set; } = string.Empty;
    public int Age { get; set; }
    public int Level { get; set; }
}
