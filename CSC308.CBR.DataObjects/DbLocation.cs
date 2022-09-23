using System.ComponentModel.DataAnnotations.Schema;

namespace DataObjects;

public class DbLocation
{
    public Guid id { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public double rating { get; set; }
    public string image_url { get; set; }
}