namespace Models;

public class MatchResult
{
    public string MatchID { get; init; }
    public Location Winner { get; init; }
    public Location Loser { get; init; }
}