using Microsoft.EntityFrameworkCore;

namespace DataObjects.Queries;

public static class LocationQueries
{

    public static async Task<DbLocation> GetRandomLocation(
        this CBRContext context,
        IEnumerable<DbLocation>? blacklist = null
    ) {
        if (blacklist == null)
        {
            return await context.Locations.OrderBy(e => EF.Functions.Random()).FirstAsync();
        }

        var blackListIds = blacklist.Select(e => e.ID);
        return await context.Locations
            .Where(e => !blackListIds.Contains(e.ID))
            .OrderBy(e => EF.Functions.Random())
            .FirstAsync();
    }

    public static async Task<DbLocation> ModifyRating(this CBRContext context,
        Guid id, double newRating) {
        var location = await context.Locations.FirstAsync(e => e.ID == id);
        location.Rating = newRating;
        return location;
    }
}