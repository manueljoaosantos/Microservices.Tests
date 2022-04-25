using System.Text.Json;
using Core.Entities;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Data
{
    public class PeopleContextSeed
    {
        public static async Task SeedAsync(BaseContext context, ILoggerFactory loggerFactory)
        {
            try
            {
                if (!context.Person!.Any())
                {
                    var peopleData = File.ReadAllText("../Infrastructure/Data/SeedData/people.json");
                    var people = JsonSerializer.Deserialize<List<Person>>(peopleData);

                    foreach (var item in people)
                    {
                        context.Person!.Add(item);
                    }

                    await context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<BaseContext>();
                logger.LogError(ex.Message);
            }
        }
    }
}