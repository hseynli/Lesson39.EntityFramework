using _06.Projection;

using (ApplicationContext db = new ApplicationContext())
{
    var users = db.Users.Select(p => new
    {
        Name = p.Name,
        Age = p.Age,
        Company = p.Company!.Name
    });
    foreach (var user in users)
        Console.WriteLine($"{user.Name} ({user.Age}) - {user.Company}");

    Console.WriteLine(new string('-', 120));

    var usersModel = db.Users.Select(p => new UserModel
    {
        Name = p.Name,
        Age = p.Age,
        Company = p.Company!.Name
    });
    foreach (UserModel user in usersModel)
        Console.WriteLine($"{user.Name} ({user.Age}) - {user.Company}");
}

Console.WriteLine("\nDone!");