namespace DataObjects;

public class DbLocation
{
    public Guid ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Rating { get; set; }
    public string ImageUrl { get; set; }
}