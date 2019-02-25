using System;
using System.Collections.Generic;
using Bogus;
using Newtonsoft.Json;
using Utilities;

namespace Sandbox
{
    public class ReviewGenerator
    {
        public IEnumerable<Review> GenerateItems()
        {
            var testReviews = new Faker<Review>()
                .RuleFor(r => r.Id, f => f.IndexFaker)
                .RuleFor(r => r.Reviewer, f => f.Name.FullName())
                .RuleFor(r => r.ItemId, f => f.Random.Number(0,30))
                .RuleFor(r => r.ReviewText, f => f.Lorem.Paragraphs(1, 3, "\n\n"))
                .RuleFor(r => r.Rating, f => f.Random.Decimal() * 5);

            return testReviews.Generate(120);
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