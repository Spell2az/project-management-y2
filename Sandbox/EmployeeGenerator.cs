using System.Collections.Generic;
using Bogus;
using Newtonsoft.Json;
using Utilities;

namespace Sandbox
{
    public class EmployeeGenerator
    {
        public IEnumerable<Employee> GenerateItems()
        {
            var testItems = new Faker<Employee>()
                .RuleFor(e => e.FirstName, f => f.Name.FirstName())
                .RuleFor(e => e.LastName, f => f.Name.LastName())
                .RuleFor(e => e.UserId, f => f.Finance.Account())
                .RuleFor(e => e.Receive, f => f.Random.Bool())
                .RuleFor(e => e.Stow, f => f.Random.Bool())
                .RuleFor(e => e.Pick, f => f.Random.Bool())
                .RuleFor(e => e.Pack, f => f.Random.Bool())
                .RuleFor(e => e.Ship, f => f.Random.Bool());
            return testItems.Generate(30);
        }
        public string GetJson()
        {
            return JsonConvert.SerializeObject(GenerateItems(), Formatting.Indented);
        }
    }
}