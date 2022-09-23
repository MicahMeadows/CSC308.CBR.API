using System.ComponentModel.DataAnnotations.Schema;

namespace DataObjects;

public class DbMatch
{
    public Guid ID { get; set; }
    
    [ForeignKey("RedTeamLocation")]
    public Guid RedTeamID { get; set; }
    
    
    [ForeignKey("BlueTeamLocation")]
    public Guid BlueTeamID { get; set; }
    public DateTime CreationTime { get; set; }
    
    public virtual DbLocation RedTeamLocation { get; set; }
    public virtual DbLocation BlueTeamLocation { get; set; }
}