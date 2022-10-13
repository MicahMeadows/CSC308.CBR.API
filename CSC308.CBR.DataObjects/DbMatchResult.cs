using System.ComponentModel.DataAnnotations.Schema;

namespace DataObjects;

public class DbMatchResult
{
    [ForeignKey("Match")]
    public Guid MatchID { get; set; }
    
    [ForeignKey("Winner")]
    public Guid WinnerID { get; set; }
    
    [ForeignKey("Loser")]
    public Guid LoserID { get; set; }
    
    public DateTime submit_time { get; set; }
    
    public virtual DbMatch Match { get; set; }
    public virtual DbLocation Winner { get; set; }
    public virtual DbLocation Loser { get; set; }
}