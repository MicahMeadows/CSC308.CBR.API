using System.ComponentModel.DataAnnotations.Schema;

namespace CSC308.CBR.DataObjects;

[Table("Match")]
public class DbMatch
{
    public string ID { get; set; } = null!;
    public string RedTeamID { get; set; } = null!;
    public string BlueTeamID { get; set; } = null!;
    
    public DateTime CreationTime { get; set; }
    
    public virtual DbLocation? RedTeamLocation { get; set; }
    public virtual DbLocation? BlueTeamLocation { get; set; }
}