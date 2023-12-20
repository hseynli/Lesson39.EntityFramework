using _01.Migration;

// For the scaffolding: Scaffold-DbContext "Data Source=.;Initial Catalog=AdventureWorks2019;Integrated Security=True;TrustServerCertificate=True"
// And after it select this lib:
// Microsoft.EntityFrameworkCore.SqlServer

using AdventureWorks2019Context db = new AdventureWorks2019Context();
var query = db.Employees;

foreach (Employee employee in query)
{
    Console.WriteLine($"{employee.FirstName} {employee.LastName}");
}

Console.WriteLine("\nDone!");