namespace Models;

public class Match
{
    public string MatchID { get; init; }
    public Location RedTeam { get; init; } = null!;
    public Location BlueTeam { get; init; } = null!;
}