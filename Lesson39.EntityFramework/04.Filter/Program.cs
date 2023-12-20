using Microsoft.EntityFrameworkCore;

using (ApplicationContext db = new ApplicationContext())
{
    var users = db.Users.Where(p => p.Company!.Name == "Google");
    foreach (User user in users)
        Console.WriteLine($"{user.Name} ({user.Age})");
}

Console.WriteLine(new string('-', 80));

using (ApplicationContext db = new ApplicationContext())
{
    var users = db.Users.Where(p => EF.Functions.Like(p.Name!, "%Tom%"));
    foreach (User user in users)
        Console.WriteLine($"{user.Name} ({user.Age})");
}

/*
 SELECT "u"."Id", "u"."Age", "u"."CompanyId", "u"."Name"
      FROM "Users" AS "u"
      WHERE "u"."Name" LIKE '%Tom%'
 */

Console.WriteLine("\nDone!");