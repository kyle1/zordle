namespace Zordle;

public class Guess
{
    public List<GameTile> LetterTiles { get; set; } = new List<GameTile>();
    public bool IsSubmitted { get; set; } = false;
}
