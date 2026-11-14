using System.ComponentModel.DataAnnotations;

namespace BattleGameFunctions.Models;

public class Assets
{
    [Key]
    public int AssetId { get; set; }

    [Required]
    [MaxLength(100)]
    public string AssetName { get; set; } = string.Empty;

    [Required]
    [MaxLength(50)]
    public string AssetType { get; set; } = string.Empty;

    [Required]
    [MaxLength(500)]
    public string? Description { get; set; }

    public ICollection<PlayerAsset> PlayerAssets { get; set; } = new List<PlayerAsset>();
}
