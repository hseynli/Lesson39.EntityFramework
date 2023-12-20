using (ApplicationContext db = new ApplicationContext())
{
    var users = db.Users.OrderBy(p => p.Name);
    foreach (var user in users)
        Console.WriteLine($"{user.Id}.{user.Name} ({user.Age})");

    /*
     SELECT "u"."Id", "u"."Age", "u"."CompanyId", "u"."Name"
     FROM "Users" AS "u"
     ORDER BY "u"."Name"
     */

    Console.WriteLine(new string('-', 120));

    var usersOrdered = from u in db.Users
                orderby u.Name
                select u;
    foreach (User user in usersOrdered)
        Console.WriteLine($"{user.Id}.{user.Name} ({user.Age})");
}

Console.WriteLine("\nDone!");