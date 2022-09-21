using Newtonsoft.Json;

namespace CSC308.CBR.DataObjects.Seeding;

public class Seeder
{
    public Root Root { get; private set; }

    public Seeder()
    {
        var jsonFile = new StreamReader("../CSC308.CBR.DataObjects/Seeding/seed-data.json");
        var jsonString = jsonFile.ReadToEnd();
        var root = JsonConvert.DeserializeObject<Root>(jsonString);
        Root = root;
    }

    public List<DbLocation> GetSeedLocations()
    {
        var seedCategories = Root.categories;
        var seedPins = seedCategories.SelectMany(e => e.pins);

        var newDbLocations = seedPins.Select(e => new DbLocation()
        {
            rating = 1,
            Description = e.description,
            Name = e.name,
            ID = e.id,
        });

        return newDbLocations.ToList();
    }
}