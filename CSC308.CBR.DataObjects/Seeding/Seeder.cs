using DataObjects;
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

        var newDbLocations = seedPins.Select(e =>
        {
            string imageUrl = "";
            
            try
            {
                imageUrl = e.images[0].path;
            }
            catch (Exception ex)
            {

            }

            return new DbLocation()
            {
                Rating = 1,
                Description = e.description,
                Name = e.name,
                ID = Guid.NewGuid(),
                ImageUrl = imageUrl,
            };
        });

        return newDbLocations.ToList();
    }
}