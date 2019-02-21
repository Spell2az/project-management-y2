using System;
using System.Collections.Generic;
using Bogus;
using Newtonsoft.Json;

namespace Utilities
{
    public class ItemGenerator
    {
        public IEnumerable<Item> GenerateItems()
        {
            var testItems = new Faker<Item>()
                .RuleFor(i => i.Id, f => f.IndexFaker)
                .RuleFor(i => i.Name, f => f.Name.FullName())
                .RuleFor(i => i.Description, f => f.Lorem.Paragraphs(1, 3, "\n\n"))
                .RuleFor(i => i.Price, f => f.Finance.Amount())
                .RuleFor(i => i.Image, f => f.Image.PicsumUrl(100, 100))
                .RuleFor(i => i.Category, f => f.PickRandom<Categories>());

            return testItems.Generate(30);
        }
        public string GetJson()
        {
            return JsonConvert.SerializeObject(GenerateItems(), Formatting.Indented);
        }
        public void WriteItemToJson()
        {
            var json = JsonConvert.SerializeObject(GenerateItems(), Formatting.Indented);

            try
            {
                System.IO.File.WriteAllText(@"E:\uni_projects\project-management-y2\Watch Shop Website\item-data.json", json);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
  
}