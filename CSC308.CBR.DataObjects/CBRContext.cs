using CSC308.CBR.DataObjects;
using CSC308.CBR.DataObjects.Seeding;
using Microsoft.EntityFrameworkCore;

namespace DataObjects;

// dotnet ef migrations add <MigrationName> -c CBRContext -o Migrations/CBRDb --project CSC308.CBR.DataObjects --startup-project CSC308.CBR.API
// dotnet ef database update -c CBRContext --project CSC308.CBR.DataObjects --startup-project CSC308.CBR.API
public class CBRContext : DbContext
{
    public DbSet<DbLocation> Locations { get; set; } = null!;
    public DbSet<DbMatch> Matches { get; set; } = null!;

    public CBRContext(DbContextOptions<CBRContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        modelBuilder.Entity<DbLocation>(ent =>
        {
            ent.HasKey(e => e.id);
            ent.Property(e => e.id).ValueGeneratedOnAdd().IsRequired();
            ent.Property(e => e.rating).IsRequired();
            ent.ToTable("Location");
        });

        var seeder = new Seeder();
        modelBuilder.Entity<DbLocation>().HasData(seeder.GetSeedLocations());
        
        modelBuilder.Entity<DbMatch>(ent =>
        {
            ent.HasKey(e => e.ID);
            ent.Property(e => e.ID).ValueGeneratedOnAdd().IsRequired();
            ent.Property(e => e.BlueTeamID).IsRequired();
            ent.Property(e => e.RedTeamID).IsRequired();
            ent.HasOne(e => e.BlueTeamLocation);
            ent.HasOne(e => e.RedTeamLocation);
            
            ent.ToTable("VoteMatch");
        });
        
        base.OnModelCreating(modelBuilder);
    }
}