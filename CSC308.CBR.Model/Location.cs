namespace Models;

public class Location
{
    public string ID { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string ImageUrl { get; set; } = null!;
    public double Rating { get; set; }
}