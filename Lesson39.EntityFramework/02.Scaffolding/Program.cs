using _02.Scaffolding;
using Microsoft.EntityFrameworkCore;

DbContextOptionsBuilder<AdventureWorks2019Context> optionsBuilder = new DbContextOptionsBuilder<AdventureWorks2019Context>();
optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=AdventureWorks2019;Integrated Security=True;TrustServerCertificate=True");

using AdventureWorks2019Context db = new AdventureWorks2019Context(optionsBuilder.Options);
var query = db.EmailAddresses;

foreach (var item in query)
{
    Console.WriteLine(item.EmailAddress1);
}

Console.WriteLine("\nDone!");