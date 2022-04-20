namespace Zordle;

public class GameTile
{
    public char Letter { get; set; } = ' ';
    public TileStatusEnum Status { get; set; } = TileStatusEnum.Empty;
}

public enum TileStatusEnum
{
    Empty,
    Absent,
    Present,
    Correct
}

