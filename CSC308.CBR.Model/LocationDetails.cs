namespace Models;

public class LocationDetails
{
    public Location Location { get; set; } = null!;
    public int? Rank { get; set; }
    public int? MatchCount { get; set; }
    public int? WinCount { get; set; }
}