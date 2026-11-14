using System.ComponentModel.DataAnnotations;

namespace BattleGameFunctions.Models;

public class Player
{
    [Key]
    public int PlayerId { get; set; }

    [Required]
    [MaxLength(50)]
    public string PlayerName { get; set; } = string.Empty;

    [Required]
    [MaxLength(100)]
    public string Fullname { get; set; } = string.Empty;

    [Range(1,120)]
    public int Age { get; set; }

    [Range(1, int.MaxValue)]
    public int Level { get; set; } = 1;

    //Quan hệ với bảng PlayerAsset
    public ICollection<PlayerAsset> PlayerAssets { get; set; } = new List<PlayerAsset>();
}