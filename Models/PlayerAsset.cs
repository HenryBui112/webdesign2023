namespace BattleGameFunctions.Models;

public class PlayerAsset
{
    public int PlayerId { get; set; }
    public int AssetId { get; set; }
    public Player Player { get; set; } = null!;
    public Assets Asset { get; set; } = null!;
}
