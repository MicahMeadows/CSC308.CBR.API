using System.ComponentModel.DataAnnotations.Schema;

namespace CSC308.CBR.DataObjects;

[Table("Location")]
public class DbLocation
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double rating { get; set; }
}